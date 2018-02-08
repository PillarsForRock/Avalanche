﻿// <copyright>
// Copyright Southeast Christian Church
//
// Licensed under the  Southeast Christian Church License (the "License");
// you may not use this file except in compliance with the License.
// A copy of the License shoud be included with this file.
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.ComponentModel;
using Rock.Model;
using Rock.Security;
using System.Web.UI;
using Rock.Web.Cache;
using Rock.Web.UI;
using System.Web;
using Rock.Data;
using System.Linq;
using System.Collections.Generic;
using Rock;
using Avalanche;
using Avalanche.Models;
using Rock.Attribute;
using Newtonsoft.Json;
using Avalanche.Attribute;

namespace RockWeb.Plugins.Avalanche
{
    [DisplayName( "Group Member List Block" )]
    [Category( "Avalanche" )]
    [Description( "Mobile block to show group members of a group." )]

    [ActionItemField( "Action Item", "Action to take upon press of item in list." )]
    public partial class GroupMemberListBlock : AvalancheBlock
    {

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Load" /> event.
        /// </summarysni>
        /// <param name="e">The <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnLoad( EventArgs e )
        {

        }

        public override MobileBlock GetMobile( string parameter )
        {
            if ( GetGroupMembers( parameter ) == null ) // send null if no parameter
            {
                return new MobileBlock()
                {
                    BlockType = "Avalanche.Blocks.Null",
                    Attributes = CustomAttributes
                };
            }


            AvalancheUtilities.SetActionItems( GetAttributeValue( "ActionItem" ), CustomAttributes, CurrentPerson );
            CustomAttributes["Request"] = parameter;        
            return new MobileBlock()
            {
                BlockType = "Avalanche.Blocks.ListViewBlock",
                Attributes = CustomAttributes
            };
        }

        public override MobileBlockResponse HandleRequest( string request, Dictionary<string, string> Body )
        {
            var groupMembers = GetGroupMembers( request );
            if ( groupMembers == null )
            {
                return new MobileBlockResponse() // send nothing if no members
                {
                    Request = request,
                    Response = JsonConvert.SerializeObject( new List<MobileListViewItem>() ),
                    TTL = 0
                };
            }

            var members = groupMembers.Select( m => new MobileListViewItem
            {
                Id = m.Guid.ToString(),
                Title = m.Person.FullName,
                Image = GlobalAttributesCache.Value( "InternalApplicationRoot" ) + m.Person.PhotoUrl + "&width=100",
                Description = m.GroupRole.Name
            } ).ToList();

            return new MobileBlockResponse()
            {
                Request = request,
                Response = JsonConvert.SerializeObject( members ),
                TTL = 0
            };
        }

        private List<GroupMember> GetGroupMembers( string parameter )
        {
            if ( CurrentPerson == null )
            {
                return null;
            }

            var groupGuid = parameter.AsGuid();
            RockContext rockContext = new RockContext();
            GroupService groupService = new GroupService( rockContext );
            var group = groupService.Get( groupGuid );

            if ( group == null )
            {
                return null;
            }

            var personId = CurrentPerson.Id;
            var members = group.Members;
            var leaders = members.Where( m => m.PersonId == personId && m.GroupRole.IsLeader );
            if ( !leaders.Any() )
            {
                return null;
            }

            return members
                .OrderByDescending( m => m.GroupRole.IsLeader )
                .ThenBy( m => m.Person.FirstName )
                .ThenBy( m => m.Person.LastName )
                .ToList()
                .Where( m => m.GroupMemberStatus != GroupMemberStatus.Inactive )
                .ToList();
        }
    }
}