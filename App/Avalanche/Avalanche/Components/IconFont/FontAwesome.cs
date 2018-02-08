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
using System.Collections.Generic;
using System.Text;

namespace Avalanche.Components.IconFont
{
    public class FontAwesome : IIconFont
    {
        public string iOSFont { get { return "fontawesome"; } }
        public string AndroidFont { get { return "fontawesome.ttf#fontawesome"; } }
        public Dictionary<string, string> LookupTable
        {
            get
            {
                return new Dictionary<string, string> {
            {"fa fa-500px", "\uf26e"},
            {"fa fa-address-book", "\uf2b9"},
            {"fa fa-address-book-o", "\uf2ba"},
            {"fa fa-address-card", "\uf2bb"},
            {"fa fa-address-card-o", "\uf2bc"},
            {"fa fa-adjust", "\uf042"},
            {"fa fa-adn", "\uf170"},
            {"fa fa-align-center", "\uf037"},
            {"fa fa-align-justify", "\uf039"},
            {"fa fa-align-left", "\uf036"},
            {"fa fa-align-right", "\uf038"},
            {"fa fa-amazon", "\uf270"},
            {"fa fa-ambulance", "\uf0f9"},
            {"fa fa-american-sign-language-interpreting", "\uf2a3"},
            {"fa fa-anchor", "\uf13d"},
            {"fa fa-android", "\uf17b"},
            {"fa fa-angellist", "\uf209"},
            {"fa fa-angle-double-down", "\uf103"},
            {"fa fa-angle-double-left", "\uf100"},
            {"fa fa-angle-double-right", "\uf101"},
            {"fa fa-angle-double-up", "\uf102"},
            {"fa fa-angle-down", "\uf107"},
            {"fa fa-angle-left", "\uf104"},
            {"fa fa-angle-right", "\uf105"},
            {"fa fa-angle-up", "\uf106"},
            {"fa fa-apple", "\uf179"},
            {"fa fa-archive", "\uf187"},
            {"fa fa-area-chart", "\uf1fe"},
            {"fa fa-arrow-circle-down", "\uf0ab"},
            {"fa fa-arrow-circle-left", "\uf0a8"},
            {"fa fa-arrow-circle-o-down", "\uf01a"},
            {"fa fa-arrow-circle-o-left", "\uf190"},
            {"fa fa-arrow-circle-o-right", "\uf18e"},
            {"fa fa-arrow-circle-o-up", "\uf01b"},
            {"fa fa-arrow-circle-right", "\uf0a9"},
            {"fa fa-arrow-circle-up", "\uf0aa"},
            {"fa fa-arrow-down", "\uf063"},
            {"fa fa-arrow-left", "\uf060"},
            {"fa fa-arrow-right", "\uf061"},
            {"fa fa-arrow-up", "\uf062"},
            {"fa fa-arrows", "\uf047"},
            {"fa fa-arrows-alt", "\uf0b2"},
            {"fa fa-arrows-h", "\uf07e"},
            {"fa fa-arrows-v", "\uf07d"},
            {"fa fa-asl-interpreting", "\uf2a3"},
            {"fa fa-assistive-listening-systems", "\uf2a2"},
            {"fa fa-asterisk", "\uf069"},
            {"fa fa-at", "\uf1fa"},
            {"fa fa-audio-description", "\uf29e"},
            {"fa fa-automobile", "\uf1b9"},
            {"fa fa-backward", "\uf04a"},
            {"fa fa-balance-scale", "\uf24e"},
            {"fa fa-ban", "\uf05e"},
            {"fa fa-bandcamp", "\uf2d5"},
            {"fa fa-bank", "\uf19c"},
            {"fa fa-bar-chart", "\uf080"},
            {"fa fa-bar-chart-o", "\uf080"},
            {"fa fa-barcode", "\uf02a"},
            {"fa fa-bars", "\uf0c9"},
            {"fa fa-bath", "\uf2cd"},
            {"fa fa-bathtub", "\uf2cd"},
            {"fa fa-battery", "\uf240"},
            {"fa fa-battery-0", "\uf244"},
            {"fa fa-battery-1", "\uf243"},
            {"fa fa-battery-2", "\uf242"},
            {"fa fa-battery-3", "\uf241"},
            {"fa fa-battery-4", "\uf240"},
            {"fa fa-battery-empty", "\uf244"},
            {"fa fa-battery-full", "\uf240"},
            {"fa fa-battery-half", "\uf242"},
            {"fa fa-battery-quarter", "\uf243"},
            {"fa fa-battery-three-quarters", "\uf241"},
            {"fa fa-bed", "\uf236"},
            {"fa fa-beer", "\uf0fc"},
            {"fa fa-behance", "\uf1b4"},
            {"fa fa-behance-square", "\uf1b5"},
            {"fa fa-bell", "\uf0f3"},
            {"fa fa-bell-o", "\uf0a2"},
            {"fa fa-bell-slash", "\uf1f6"},
            {"fa fa-bell-slash-o", "\uf1f7"},
            {"fa fa-bicycle", "\uf206"},
            {"fa fa-binoculars", "\uf1e5"},
            {"fa fa-birthday-cake", "\uf1fd"},
            {"fa fa-bitbucket", "\uf171"},
            {"fa fa-bitbucket-square", "\uf172"},
            {"fa fa-bitcoin", "\uf15a"},
            {"fa fa-black-tie", "\uf27e"},
            {"fa fa-blind", "\uf29d"},
            {"fa fa-bluetooth", "\uf293"},
            {"fa fa-bluetooth-b", "\uf294"},
            {"fa fa-bold", "\uf032"},
            {"fa fa-bolt", "\uf0e7"},
            {"fa fa-bomb", "\uf1e2"},
            {"fa fa-book", "\uf02d"},
            {"fa fa-bookmark", "\uf02e"},
            {"fa fa-bookmark-o", "\uf097"},
            {"fa fa-braille", "\uf2a1"},
            {"fa fa-briefcase", "\uf0b1"},
            {"fa fa-btc", "\uf15a"},
            {"fa fa-bug", "\uf188"},
            {"fa fa-building", "\uf1ad"},
            {"fa fa-building-o", "\uf0f7"},
            {"fa fa-bullhorn", "\uf0a1"},
            {"fa fa-bullseye", "\uf140"},
            {"fa fa-bus", "\uf207"},
            {"fa fa-buysellads", "\uf20d"},
            {"fa fa-cab", "\uf1ba"},
            {"fa fa-calculator", "\uf1ec"},
            {"fa fa-calendar", "\uf073"},
            {"fa fa-calendar-check-o", "\uf274"},
            {"fa fa-calendar-minus-o", "\uf272"},
            {"fa fa-calendar-o", "\uf133"},
            {"fa fa-calendar-plus-o", "\uf271"},
            {"fa fa-calendar-times-o", "\uf273"},
            {"fa fa-camera", "\uf030"},
            {"fa fa-camera-retro", "\uf083"},
            {"fa fa-car", "\uf1b9"},
            {"fa fa-caret-down", "\uf0d7"},
            {"fa fa-caret-left", "\uf0d9"},
            {"fa fa-caret-right", "\uf0da"},
            {"fa fa-caret-square-o-down", "\uf150"},
            {"fa fa-caret-square-o-left", "\uf191"},
            {"fa fa-caret-square-o-right", "\uf152"},
            {"fa fa-caret-square-o-up", "\uf151"},
            {"fa fa-caret-up", "\uf0d8"},
            {"fa fa-cart-arrow-down", "\uf218"},
            {"fa fa-cart-plus", "\uf217"},
            {"fa fa-cc", "\uf20a"},
            {"fa fa-cc-amex", "\uf1f3"},
            {"fa fa-cc-diners-club", "\uf24c"},
            {"fa fa-cc-discover", "\uf1f2"},
            {"fa fa-cc-jcb", "\uf24b"},
            {"fa fa-cc-mastercard", "\uf1f1"},
            {"fa fa-cc-paypal", "\uf1f4"},
            {"fa fa-cc-stripe", "\uf1f5"},
            {"fa fa-cc-visa", "\uf1f0"},
            {"fa fa-certificate", "\uf0a3"},
            {"fa fa-chain", "\uf0c1"},
            {"fa fa-chain-broken", "\uf127"},
            {"fa fa-check", "\uf00c"},
            {"fa fa-check-circle", "\uf058"},
            {"fa fa-check-circle-o", "\uf05d"},
            {"fa fa-check-square", "\uf14a"},
            {"fa fa-check-square-o", "\uf046"},
            {"fa fa-chevron-circle-down", "\uf13a"},
            {"fa fa-chevron-circle-left", "\uf137"},
            {"fa fa-chevron-circle-right", "\uf138"},
            {"fa fa-chevron-circle-up", "\uf139"},
            {"fa fa-chevron-down", "\uf078"},
            {"fa fa-chevron-left", "\uf053"},
            {"fa fa-chevron-right", "\uf054"},
            {"fa fa-chevron-up", "\uf077"},
            {"fa fa-child", "\uf1ae"},
            {"fa fa-chrome", "\uf268"},
            {"fa fa-circle", "\uf111"},
            {"fa fa-circle-o", "\uf10c"},
            {"fa fa-circle-o-notch", "\uf1ce"},
            {"fa fa-circle-thin", "\uf1db"},
            {"fa fa-clipboard", "\uf0ea"},
            {"fa fa-clock-o", "\uf017"},
            {"fa fa-clone", "\uf24d"},
            {"fa fa-close", "\uf00d"},
            {"fa fa-cloud", "\uf0c2"},
            {"fa fa-cloud-download", "\uf0ed"},
            {"fa fa-cloud-upload", "\uf0ee"},
            {"fa fa-cny", "\uf157"},
            {"fa fa-code", "\uf121"},
            {"fa fa-code-fork", "\uf126"},
            {"fa fa-codepen", "\uf1cb"},
            {"fa fa-codiepie", "\uf284"},
            {"fa fa-coffee", "\uf0f4"},
            {"fa fa-cog", "\uf013"},
            {"fa fa-cogs", "\uf085"},
            {"fa fa-columns", "\uf0db"},
            {"fa fa-comment", "\uf075"},
            {"fa fa-comment-o", "\uf0e5"},
            {"fa fa-commenting", "\uf27a"},
            {"fa fa-commenting-o", "\uf27b"},
            {"fa fa-comments", "\uf086"},
            {"fa fa-comments-o", "\uf0e6"},
            {"fa fa-compass", "\uf14e"},
            {"fa fa-compress", "\uf066"},
            {"fa fa-connectdevelop", "\uf20e"},
            {"fa fa-contao", "\uf26d"},
            {"fa fa-copy", "\uf0c5"},
            {"fa fa-copyright", "\uf1f9"},
            {"fa fa-creative-commons", "\uf25e"},
            {"fa fa-credit-card", "\uf09d"},
            {"fa fa-credit-card-alt", "\uf283"},
            {"fa fa-crop", "\uf125"},
            {"fa fa-crosshairs", "\uf05b"},
            {"fa fa-css3", "\uf13c"},
            {"fa fa-cube", "\uf1b2"},
            {"fa fa-cubes", "\uf1b3"},
            {"fa fa-cut", "\uf0c4"},
            {"fa fa-cutlery", "\uf0f5"},
            {"fa fa-dashboard", "\uf0e4"},
            {"fa fa-dashcube", "\uf210"},
            {"fa fa-database", "\uf1c0"},
            {"fa fa-deaf", "\uf2a4"},
            {"fa fa-deafness", "\uf2a4"},
            {"fa fa-dedent", "\uf03b"},
            {"fa fa-delicious", "\uf1a5"},
            {"fa fa-desktop", "\uf108"},
            {"fa fa-deviantart", "\uf1bd"},
            {"fa fa-diamond", "\uf219"},
            {"fa fa-digg", "\uf1a6"},
            {"fa fa-dollar", "\uf155"},
            {"fa fa-dot-circle-o", "\uf192"},
            {"fa fa-download", "\uf019"},
            {"fa fa-dribbble", "\uf17d"},
            {"fa fa-drivers-license", "\uf2c2"},
            {"fa fa-drivers-license-o", "\uf2c3"},
            {"fa fa-dropbox", "\uf16b"},
            {"fa fa-drupal", "\uf1a9"},
            {"fa fa-edge", "\uf282"},
            {"fa fa-edit", "\uf044"},
            {"fa fa-eercast", "\uf2da"},
            {"fa fa-eject", "\uf052"},
            {"fa fa-ellipsis-h", "\uf141"},
            {"fa fa-ellipsis-v", "\uf142"},
            {"fa fa-empire", "\uf1d1"},
            {"fa fa-envelope", "\uf0e0"},
            {"fa fa-envelope-o", "\uf003"},
            {"fa fa-envelope-open", "\uf2b6"},
            {"fa fa-envelope-open-o", "\uf2b7"},
            {"fa fa-envelope-square", "\uf199"},
            {"fa fa-envira", "\uf299"},
            {"fa fa-eraser", "\uf12d"},
            {"fa fa-etsy", "\uf2d7"},
            {"fa fa-eur", "\uf153"},
            {"fa fa-euro", "\uf153"},
            {"fa fa-exchange", "\uf0ec"},
            {"fa fa-exclamation", "\uf12a"},
            {"fa fa-exclamation-circle", "\uf06a"},
            {"fa fa-exclamation-triangle", "\uf071"},
            {"fa fa-expand", "\uf065"},
            {"fa fa-expeditedssl", "\uf23e"},
            {"fa fa-external-link", "\uf08e"},
            {"fa fa-external-link-square", "\uf14c"},
            {"fa fa-eye", "\uf06e"},
            {"fa fa-eye-slash", "\uf070"},
            {"fa fa-eyedropper", "\uf1fb"},
            {"fa fa-fa", "\uf2b4"},
            {"fa fa-facebook", "\uf09a"},
            {"fa fa-facebook-f", "\uf09a"},
            {"fa fa-facebook-official", "\uf230"},
            {"fa fa-facebook-square", "\uf082"},
            {"fa fa-fast-backward", "\uf049"},
            {"fa fa-fast-forward", "\uf050"},
            {"fa fa-fax", "\uf1ac"},
            {"fa fa-feed", "\uf09e"},
            {"fa fa-female", "\uf182"},
            {"fa fa-fighter-jet", "\uf0fb"},
            {"fa fa-file", "\uf15b"},
            {"fa fa-file-archive-o", "\uf1c6"},
            {"fa fa-file-audio-o", "\uf1c7"},
            {"fa fa-file-code-o", "\uf1c9"},
            {"fa fa-file-excel-o", "\uf1c3"},
            {"fa fa-file-image-o", "\uf1c5"},
            {"fa fa-file-movie-o", "\uf1c8"},
            {"fa fa-file-o", "\uf016"},
            {"fa fa-file-pdf-o", "\uf1c1"},
            {"fa fa-file-photo-o", "\uf1c5"},
            {"fa fa-file-picture-o", "\uf1c5"},
            {"fa fa-file-powerpoint-o", "\uf1c4"},
            {"fa fa-file-sound-o", "\uf1c7"},
            {"fa fa-file-text", "\uf15c"},
            {"fa fa-file-text-o", "\uf0f6"},
            {"fa fa-file-video-o", "\uf1c8"},
            {"fa fa-file-word-o", "\uf1c2"},
            {"fa fa-file-zip-o", "\uf1c6"},
            {"fa fa-files-o", "\uf0c5"},
            {"fa fa-film", "\uf008"},
            {"fa fa-filter", "\uf0b0"},
            {"fa fa-fire", "\uf06d"},
            {"fa fa-fire-extinguisher", "\uf134"},
            {"fa fa-firefox", "\uf269"},
            {"fa fa-first-order", "\uf2b0"},
            {"fa fa-flag", "\uf024"},
            {"fa fa-flag-checkered", "\uf11e"},
            {"fa fa-flag-o", "\uf11d"},
            {"fa fa-flash", "\uf0e7"},
            {"fa fa-flask", "\uf0c3"},
            {"fa fa-flickr", "\uf16e"},
            {"fa fa-floppy-o", "\uf0c7"},
            {"fa fa-folder", "\uf07b"},
            {"fa fa-folder-o", "\uf114"},
            {"fa fa-folder-open", "\uf07c"},
            {"fa fa-folder-open-o", "\uf115"},
            {"fa fa-font", "\uf031"},
            {"fa fa-font-awesome", "\uf2b4"},
            {"fa fa-fonticons", "\uf280"},
            {"fa fa-fort-awesome", "\uf286"},
            {"fa fa-forumbee", "\uf211"},
            {"fa fa-forward", "\uf04e"},
            {"fa fa-foursquare", "\uf180"},
            {"fa fa-free-code-camp", "\uf2c5"},
            {"fa fa-frown-o", "\uf119"},
            {"fa fa-futbol-o", "\uf1e3"},
            {"fa fa-gamepad", "\uf11b"},
            {"fa fa-gavel", "\uf0e3"},
            {"fa fa-gbp", "\uf154"},
            {"fa fa-ge", "\uf1d1"},
            {"fa fa-gear", "\uf013"},
            {"fa fa-gears", "\uf085"},
            {"fa fa-genderless", "\uf22d"},
            {"fa fa-get-pocket", "\uf265"},
            {"fa fa-gg", "\uf260"},
            {"fa fa-gg-circle", "\uf261"},
            {"fa fa-gift", "\uf06b"},
            {"fa fa-git", "\uf1d3"},
            {"fa fa-git-square", "\uf1d2"},
            {"fa fa-github", "\uf09b"},
            {"fa fa-github-alt", "\uf113"},
            {"fa fa-github-square", "\uf092"},
            {"fa fa-gitlab", "\uf296"},
            {"fa fa-gittip", "\uf184"},
            {"fa fa-glass", "\uf000"},
            {"fa fa-glide", "\uf2a5"},
            {"fa fa-glide-g", "\uf2a6"},
            {"fa fa-globe", "\uf0ac"},
            {"fa fa-google", "\uf1a0"},
            {"fa fa-google-plus", "\uf0d5"},
            {"fa fa-google-plus-circle", "\uf2b3"},
            {"fa fa-google-plus-official", "\uf2b3"},
            {"fa fa-google-plus-square", "\uf0d4"},
            {"fa fa-google-wallet", "\uf1ee"},
            {"fa fa-graduation-cap", "\uf19d"},
            {"fa fa-gratipay", "\uf184"},
            {"fa fa-grav", "\uf2d6"},
            {"fa fa-group", "\uf0c0"},
            {"fa fa-h-square", "\uf0fd"},
            {"fa fa-hacker-news", "\uf1d4"},
            {"fa fa-hand-grab-o", "\uf255"},
            {"fa fa-hand-lizard-o", "\uf258"},
            {"fa fa-hand-o-down", "\uf0a7"},
            {"fa fa-hand-o-left", "\uf0a5"},
            {"fa fa-hand-o-right", "\uf0a4"},
            {"fa fa-hand-o-up", "\uf0a6"},
            {"fa fa-hand-paper-o", "\uf256"},
            {"fa fa-hand-peace-o", "\uf25b"},
            {"fa fa-hand-pointer-o", "\uf25a"},
            {"fa fa-hand-rock-o", "\uf255"},
            {"fa fa-hand-scissors-o", "\uf257"},
            {"fa fa-hand-spock-o", "\uf259"},
            {"fa fa-hand-stop-o", "\uf256"},
            {"fa fa-handshake-o", "\uf2b5"},
            {"fa fa-hard-of-hearing", "\uf2a4"},
            {"fa fa-hashtag", "\uf292"},
            {"fa fa-hdd-o", "\uf0a0"},
            {"fa fa-header", "\uf1dc"},
            {"fa fa-headphones", "\uf025"},
            {"fa fa-heart", "\uf004"},
            {"fa fa-heart-o", "\uf08a"},
            {"fa fa-heartbeat", "\uf21e"},
            {"fa fa-history", "\uf1da"},
            {"fa fa-home", "\uf015"},
            {"fa fa-hospital-o", "\uf0f8"},
            {"fa fa-hotel", "\uf236"},
            {"fa fa-hourglass", "\uf254"},
            {"fa fa-hourglass-1", "\uf251"},
            {"fa fa-hourglass-2", "\uf252"},
            {"fa fa-hourglass-3", "\uf253"},
            {"fa fa-hourglass-end", "\uf253"},
            {"fa fa-hourglass-half", "\uf252"},
            {"fa fa-hourglass-o", "\uf250"},
            {"fa fa-hourglass-start", "\uf251"},
            {"fa fa-houzz", "\uf27c"},
            {"fa fa-html5", "\uf13b"},
            {"fa fa-i-cursor", "\uf246"},
            {"fa fa-id-badge", "\uf2c1"},
            {"fa fa-id-card", "\uf2c2"},
            {"fa fa-id-card-o", "\uf2c3"},
            {"fa fa-ils", "\uf20b"},
            {"fa fa-image", "\uf03e"},
            {"fa fa-imdb", "\uf2d8"},
            {"fa fa-inbox", "\uf01c"},
            {"fa fa-indent", "\uf03c"},
            {"fa fa-industry", "\uf275"},
            {"fa fa-info", "\uf129"},
            {"fa fa-info-circle", "\uf05a"},
            {"fa fa-inr", "\uf156"},
            {"fa fa-instagram", "\uf16d"},
            {"fa fa-institution", "\uf19c"},
            {"fa fa-internet-explorer", "\uf26b"},
            {"fa fa-intersex", "\uf224"},
            {"fa fa-ioxhost", "\uf208"},
            {"fa fa-italic", "\uf033"},
            {"fa fa-joomla", "\uf1aa"},
            {"fa fa-jpy", "\uf157"},
            {"fa fa-jsfiddle", "\uf1cc"},
            {"fa fa-key", "\uf084"},
            {"fa fa-keyboard-o", "\uf11c"},
            {"fa fa-krw", "\uf159"},
            {"fa fa-language", "\uf1ab"},
            {"fa fa-laptop", "\uf109"},
            {"fa fa-lastfm", "\uf202"},
            {"fa fa-lastfm-square", "\uf203"},
            {"fa fa-leaf", "\uf06c"},
            {"fa fa-leanpub", "\uf212"},
            {"fa fa-legal", "\uf0e3"},
            {"fa fa-lemon-o", "\uf094"},
            {"fa fa-level-down", "\uf149"},
            {"fa fa-level-up", "\uf148"},
            {"fa fa-life-bouy", "\uf1cd"},
            {"fa fa-life-buoy", "\uf1cd"},
            {"fa fa-life-ring", "\uf1cd"},
            {"fa fa-life-saver", "\uf1cd"},
            {"fa fa-lightbulb-o", "\uf0eb"},
            {"fa fa-line-chart", "\uf201"},
            {"fa fa-link", "\uf0c1"},
            {"fa fa-linkedin", "\uf0e1"},
            {"fa fa-linkedin-square", "\uf08c"},
            {"fa fa-linode", "\uf2b8"},
            {"fa fa-linux", "\uf17c"},
            {"fa fa-list", "\uf03a"},
            {"fa fa-list-alt", "\uf022"},
            {"fa fa-list-ol", "\uf0cb"},
            {"fa fa-list-ul", "\uf0ca"},
            {"fa fa-location-arrow", "\uf124"},
            {"fa fa-lock", "\uf023"},
            {"fa fa-long-arrow-down", "\uf175"},
            {"fa fa-long-arrow-left", "\uf177"},
            {"fa fa-long-arrow-right", "\uf178"},
            {"fa fa-long-arrow-up", "\uf176"},
            {"fa fa-low-vision", "\uf2a8"},
            {"fa fa-magic", "\uf0d0"},
            {"fa fa-magnet", "\uf076"},
            {"fa fa-mail-forward", "\uf064"},
            {"fa fa-mail-reply", "\uf112"},
            {"fa fa-mail-reply-all", "\uf122"},
            {"fa fa-male", "\uf183"},
            {"fa fa-map", "\uf279"},
            {"fa fa-map-marker", "\uf041"},
            {"fa fa-map-o", "\uf278"},
            {"fa fa-map-pin", "\uf276"},
            {"fa fa-map-signs", "\uf277"},
            {"fa fa-mars", "\uf222"},
            {"fa fa-mars-double", "\uf227"},
            {"fa fa-mars-stroke", "\uf229"},
            {"fa fa-mars-stroke-h", "\uf22b"},
            {"fa fa-mars-stroke-v", "\uf22a"},
            {"fa fa-maxcdn", "\uf136"},
            {"fa fa-meanpath", "\uf20c"},
            {"fa fa-medium", "\uf23a"},
            {"fa fa-medkit", "\uf0fa"},
            {"fa fa-meetup", "\uf2e0"},
            {"fa fa-meh-o", "\uf11a"},
            {"fa fa-mercury", "\uf223"},
            {"fa fa-microchip", "\uf2db"},
            {"fa fa-microphone", "\uf130"},
            {"fa fa-microphone-slash", "\uf131"},
            {"fa fa-minus", "\uf068"},
            {"fa fa-minus-circle", "\uf056"},
            {"fa fa-minus-square", "\uf146"},
            {"fa fa-minus-square-o", "\uf147"},
            {"fa fa-mixcloud", "\uf289"},
            {"fa fa-mobile", "\uf10b"},
            {"fa fa-mobile-phone", "\uf10b"},
            {"fa fa-modx", "\uf285"},
            {"fa fa-money", "\uf0d6"},
            {"fa fa-moon-o", "\uf186"},
            {"fa fa-mortar-board", "\uf19d"},
            {"fa fa-motorcycle", "\uf21c"},
            {"fa fa-mouse-pointer", "\uf245"},
            {"fa fa-music", "\uf001"},
            {"fa fa-navicon", "\uf0c9"},
            {"fa fa-neuter", "\uf22c"},
            {"fa fa-newspaper-o", "\uf1ea"},
            {"fa fa-object-group", "\uf247"},
            {"fa fa-object-ungroup", "\uf248"},
            {"fa fa-odnoklassniki", "\uf263"},
            {"fa fa-odnoklassniki-square", "\uf264"},
            {"fa fa-opencart", "\uf23d"},
            {"fa fa-openid", "\uf19b"},
            {"fa fa-opera", "\uf26a"},
            {"fa fa-optin-monster", "\uf23c"},
            {"fa fa-outdent", "\uf03b"},
            {"fa fa-pagelines", "\uf18c"},
            {"fa fa-paint-brush", "\uf1fc"},
            {"fa fa-paper-plane", "\uf1d8"},
            {"fa fa-paper-plane-o", "\uf1d9"},
            {"fa fa-paperclip", "\uf0c6"},
            {"fa fa-paragraph", "\uf1dd"},
            {"fa fa-paste", "\uf0ea"},
            {"fa fa-pause", "\uf04c"},
            {"fa fa-pause-circle", "\uf28b"},
            {"fa fa-pause-circle-o", "\uf28c"},
            {"fa fa-paw", "\uf1b0"},
            {"fa fa-paypal", "\uf1ed"},
            {"fa fa-pencil", "\uf040"},
            {"fa fa-pencil-square", "\uf14b"},
            {"fa fa-pencil-square-o", "\uf044"},
            {"fa fa-percent", "\uf295"},
            {"fa fa-phone", "\uf095"},
            {"fa fa-phone-square", "\uf098"},
            {"fa fa-photo", "\uf03e"},
            {"fa fa-picture-o", "\uf03e"},
            {"fa fa-pie-chart", "\uf200"},
            {"fa fa-pied-piper", "\uf2ae"},
            {"fa fa-pied-piper-alt", "\uf1a8"},
            {"fa fa-pied-piper-pp", "\uf1a7"},
            {"fa fa-pinterest", "\uf0d2"},
            {"fa fa-pinterest-p", "\uf231"},
            {"fa fa-pinterest-square", "\uf0d3"},
            {"fa fa-plane", "\uf072"},
            {"fa fa-play", "\uf04b"},
            {"fa fa-play-circle", "\uf144"},
            {"fa fa-play-circle-o", "\uf01d"},
            {"fa fa-plug", "\uf1e6"},
            {"fa fa-plus", "\uf067"},
            {"fa fa-plus-circle", "\uf055"},
            {"fa fa-plus-square", "\uf0fe"},
            {"fa fa-plus-square-o", "\uf196"},
            {"fa fa-podcast", "\uf2ce"},
            {"fa fa-power-off", "\uf011"},
            {"fa fa-print", "\uf02f"},
            {"fa fa-product-hunt", "\uf288"},
            {"fa fa-puzzle-piece", "\uf12e"},
            {"fa fa-qq", "\uf1d6"},
            {"fa fa-qrcode", "\uf029"},
            {"fa fa-question", "\uf128"},
            {"fa fa-question-circle", "\uf059"},
            {"fa fa-question-circle-o", "\uf29c"},
            {"fa fa-quora", "\uf2c4"},
            {"fa fa-quote-left", "\uf10d"},
            {"fa fa-quote-right", "\uf10e"},
            {"fa fa-ra", "\uf1d0"},
            {"fa fa-random", "\uf074"},
            {"fa fa-ravelry", "\uf2d9"},
            {"fa fa-rebel", "\uf1d0"},
            {"fa fa-recycle", "\uf1b8"},
            {"fa fa-reddit", "\uf1a1"},
            {"fa fa-reddit-alien", "\uf281"},
            {"fa fa-reddit-square", "\uf1a2"},
            {"fa fa-refresh", "\uf021"},
            {"fa fa-registered", "\uf25d"},
            {"fa fa-remove", "\uf00d"},
            {"fa fa-renren", "\uf18b"},
            {"fa fa-reorder", "\uf0c9"},
            {"fa fa-repeat", "\uf01e"},
            {"fa fa-reply", "\uf112"},
            {"fa fa-reply-all", "\uf122"},
            {"fa fa-resistance", "\uf1d0"},
            {"fa fa-retweet", "\uf079"},
            {"fa fa-rmb", "\uf157"},
            {"fa fa-road", "\uf018"},
            {"fa fa-rocket", "\uf135"},
            {"fa fa-rotate-left", "\uf0e2"},
            {"fa fa-rotate-right", "\uf01e"},
            {"fa fa-rouble", "\uf158"},
            {"fa fa-rss", "\uf09e"},
            {"fa fa-rss-square", "\uf143"},
            {"fa fa-rub", "\uf158"},
            {"fa fa-ruble", "\uf158"},
            {"fa fa-rupee", "\uf156"},
            {"fa fa-s15", "\uf2cd"},
            {"fa fa-safari", "\uf267"},
            {"fa fa-save", "\uf0c7"},
            {"fa fa-scissors", "\uf0c4"},
            {"fa fa-scribd", "\uf28a"},
            {"fa fa-search", "\uf002"},
            {"fa fa-search-minus", "\uf010"},
            {"fa fa-search-plus", "\uf00e"},
            {"fa fa-sellsy", "\uf213"},
            {"fa fa-send", "\uf1d8"},
            {"fa fa-send-o", "\uf1d9"},
            {"fa fa-server", "\uf233"},
            {"fa fa-share", "\uf064"},
            {"fa fa-share-alt", "\uf1e0"},
            {"fa fa-share-alt-square", "\uf1e1"},
            {"fa fa-share-square", "\uf14d"},
            {"fa fa-share-square-o", "\uf045"},
            {"fa fa-shekel", "\uf20b"},
            {"fa fa-sheqel", "\uf20b"},
            {"fa fa-shield", "\uf132"},
            {"fa fa-ship", "\uf21a"},
            {"fa fa-shirtsinbulk", "\uf214"},
            {"fa fa-shopping-bag", "\uf290"},
            {"fa fa-shopping-basket", "\uf291"},
            {"fa fa-shopping-cart", "\uf07a"},
            {"fa fa-shower", "\uf2cc"},
            {"fa fa-sign-in", "\uf090"},
            {"fa fa-sign-language", "\uf2a7"},
            {"fa fa-sign-out", "\uf08b"},
            {"fa fa-signal", "\uf012"},
            {"fa fa-signing", "\uf2a7"},
            {"fa fa-simplybuilt", "\uf215"},
            {"fa fa-sitemap", "\uf0e8"},
            {"fa fa-skyatlas", "\uf216"},
            {"fa fa-skype", "\uf17e"},
            {"fa fa-slack", "\uf198"},
            {"fa fa-sliders", "\uf1de"},
            {"fa fa-slideshare", "\uf1e7"},
            {"fa fa-smile-o", "\uf118"},
            {"fa fa-snapchat", "\uf2ab"},
            {"fa fa-snapchat-ghost", "\uf2ac"},
            {"fa fa-snapchat-square", "\uf2ad"},
            {"fa fa-snowflake-o", "\uf2dc"},
            {"fa fa-soccer-ball-o", "\uf1e3"},
            {"fa fa-sort", "\uf0dc"},
            {"fa fa-sort-alpha-asc", "\uf15d"},
            {"fa fa-sort-alpha-desc", "\uf15e"},
            {"fa fa-sort-amount-asc", "\uf160"},
            {"fa fa-sort-amount-desc", "\uf161"},
            {"fa fa-sort-asc", "\uf0de"},
            {"fa fa-sort-desc", "\uf0dd"},
            {"fa fa-sort-down", "\uf0dd"},
            {"fa fa-sort-numeric-asc", "\uf162"},
            {"fa fa-sort-numeric-desc", "\uf163"},
            {"fa fa-sort-up", "\uf0de"},
            {"fa fa-soundcloud", "\uf1be"},
            {"fa fa-space-shuttle", "\uf197"},
            {"fa fa-spinner", "\uf110"},
            {"fa fa-spoon", "\uf1b1"},
            {"fa fa-spotify", "\uf1bc"},
            {"fa fa-square", "\uf0c8"},
            {"fa fa-square-o", "\uf096"},
            {"fa fa-stack-exchange", "\uf18d"},
            {"fa fa-stack-overflow", "\uf16c"},
            {"fa fa-star", "\uf005"},
            {"fa fa-star-half", "\uf089"},
            {"fa fa-star-half-empty", "\uf123"},
            {"fa fa-star-half-full", "\uf123"},
            {"fa fa-star-half-o", "\uf123"},
            {"fa fa-star-o", "\uf006"},
            {"fa fa-steam", "\uf1b6"},
            {"fa fa-steam-square", "\uf1b7"},
            {"fa fa-step-backward", "\uf048"},
            {"fa fa-step-forward", "\uf051"},
            {"fa fa-stethoscope", "\uf0f1"},
            {"fa fa-sticky-note", "\uf249"},
            {"fa fa-sticky-note-o", "\uf24a"},
            {"fa fa-stop", "\uf04d"},
            {"fa fa-stop-circle", "\uf28d"},
            {"fa fa-stop-circle-o", "\uf28e"},
            {"fa fa-street-view", "\uf21d"},
            {"fa fa-strikethrough", "\uf0cc"},
            {"fa fa-stumbleupon", "\uf1a4"},
            {"fa fa-stumbleupon-circle", "\uf1a3"},
            {"fa fa-subscript", "\uf12c"},
            {"fa fa-subway", "\uf239"},
            {"fa fa-suitcase", "\uf0f2"},
            {"fa fa-sun-o", "\uf185"},
            {"fa fa-superpowers", "\uf2dd"},
            {"fa fa-superscript", "\uf12b"},
            {"fa fa-support", "\uf1cd"},
            {"fa fa-table", "\uf0ce"},
            {"fa fa-tablet", "\uf10a"},
            {"fa fa-tachometer", "\uf0e4"},
            {"fa fa-tag", "\uf02b"},
            {"fa fa-tags", "\uf02c"},
            {"fa fa-tasks", "\uf0ae"},
            {"fa fa-taxi", "\uf1ba"},
            {"fa fa-telegram", "\uf2c6"},
            {"fa fa-television", "\uf26c"},
            {"fa fa-tencent-weibo", "\uf1d5"},
            {"fa fa-terminal", "\uf120"},
            {"fa fa-text-height", "\uf034"},
            {"fa fa-text-width", "\uf035"},
            {"fa fa-th", "\uf00a"},
            {"fa fa-th-large", "\uf009"},
            {"fa fa-th-list", "\uf00b"},
            {"fa fa-themeisle", "\uf2b2"},
            {"fa fa-thermometer", "\uf2c7"},
            {"fa fa-thermometer-0", "\uf2cb"},
            {"fa fa-thermometer-1", "\uf2ca"},
            {"fa fa-thermometer-2", "\uf2c9"},
            {"fa fa-thermometer-3", "\uf2c8"},
            {"fa fa-thermometer-4", "\uf2c7"},
            {"fa fa-thermometer-empty", "\uf2cb"},
            {"fa fa-thermometer-full", "\uf2c7"},
            {"fa fa-thermometer-half", "\uf2c9"},
            {"fa fa-thermometer-quarter", "\uf2ca"},
            {"fa fa-thermometer-three-quarters", "\uf2c8"},
            {"fa fa-thumb-tack", "\uf08d"},
            {"fa fa-thumbs-down", "\uf165"},
            {"fa fa-thumbs-o-down", "\uf088"},
            {"fa fa-thumbs-o-up", "\uf087"},
            {"fa fa-thumbs-up", "\uf164"},
            {"fa fa-ticket", "\uf145"},
            {"fa fa-times", "\uf00d"},
            {"fa fa-times-circle", "\uf057"},
            {"fa fa-times-circle-o", "\uf05c"},
            {"fa fa-times-rectangle", "\uf2d3"},
            {"fa fa-times-rectangle-o", "\uf2d4"},
            {"fa fa-tint", "\uf043"},
            {"fa fa-toggle-down", "\uf150"},
            {"fa fa-toggle-left", "\uf191"},
            {"fa fa-toggle-off", "\uf204"},
            {"fa fa-toggle-on", "\uf205"},
            {"fa fa-toggle-right", "\uf152"},
            {"fa fa-toggle-up", "\uf151"},
            {"fa fa-trademark", "\uf25c"},
            {"fa fa-train", "\uf238"},
            {"fa fa-transgender", "\uf224"},
            {"fa fa-transgender-alt", "\uf225"},
            {"fa fa-trash", "\uf1f8"},
            {"fa fa-trash-o", "\uf014"},
            {"fa fa-tree", "\uf1bb"},
            {"fa fa-trello", "\uf181"},
            {"fa fa-tripadvisor", "\uf262"},
            {"fa fa-trophy", "\uf091"},
            {"fa fa-truck", "\uf0d1"},
            {"fa fa-try", "\uf195"},
            {"fa fa-tty", "\uf1e4"},
            {"fa fa-tumblr", "\uf173"},
            {"fa fa-tumblr-square", "\uf174"},
            {"fa fa-turkish-lira", "\uf195"},
            {"fa fa-tv", "\uf26c"},
            {"fa fa-twitch", "\uf1e8"},
            {"fa fa-twitter", "\uf099"},
            {"fa fa-twitter-square", "\uf081"},
            {"fa fa-umbrella", "\uf0e9"},
            {"fa fa-underline", "\uf0cd"},
            {"fa fa-undo", "\uf0e2"},
            {"fa fa-universal-access", "\uf29a"},
            {"fa fa-university", "\uf19c"},
            {"fa fa-unlink", "\uf127"},
            {"fa fa-unlock", "\uf09c"},
            {"fa fa-unlock-alt", "\uf13e"},
            {"fa fa-unsorted", "\uf0dc"},
            {"fa fa-upload", "\uf093"},
            {"fa fa-usb", "\uf287"},
            {"fa fa-usd", "\uf155"},
            {"fa fa-user", "\uf007"},
            {"fa fa-user-circle", "\uf2bd"},
            {"fa fa-user-circle-o", "\uf2be"},
            {"fa fa-user-md", "\uf0f0"},
            {"fa fa-user-o", "\uf2c0"},
            {"fa fa-user-plus", "\uf234"},
            {"fa fa-user-secret", "\uf21b"},
            {"fa fa-user-times", "\uf235"},
            {"fa fa-users", "\uf0c0"},
            {"fa fa-vcard", "\uf2bb"},
            {"fa fa-vcard-o", "\uf2bc"},
            {"fa fa-venus", "\uf221"},
            {"fa fa-venus-double", "\uf226"},
            {"fa fa-venus-mars", "\uf228"},
            {"fa fa-viacoin", "\uf237"},
            {"fa fa-viadeo", "\uf2a9"},
            {"fa fa-viadeo-square", "\uf2aa"},
            {"fa fa-video-camera", "\uf03d"},
            {"fa fa-vimeo", "\uf27d"},
            {"fa fa-vimeo-square", "\uf194"},
            {"fa fa-vine", "\uf1ca"},
            {"fa fa-vk", "\uf189"},
            {"fa fa-volume-control-phone", "\uf2a0"},
            {"fa fa-volume-down", "\uf027"},
            {"fa fa-volume-off", "\uf026"},
            {"fa fa-volume-up", "\uf028"},
            {"fa fa-warning", "\uf071"},
            {"fa fa-wechat", "\uf1d7"},
            {"fa fa-weibo", "\uf18a"},
            {"fa fa-weixin", "\uf1d7"},
            {"fa fa-whatsapp", "\uf232"},
            {"fa fa-wheelchair", "\uf193"},
            {"fa fa-wheelchair-alt", "\uf29b"},
            {"fa fa-wifi", "\uf1eb"},
            {"fa fa-wikipedia-w", "\uf266"},
            {"fa fa-window-close", "\uf2d3"},
            {"fa fa-window-close-o", "\uf2d4"},
            {"fa fa-window-maximize", "\uf2d0"},
            {"fa fa-window-minimize", "\uf2d1"},
            {"fa fa-window-restore", "\uf2d2"},
            {"fa fa-windows", "\uf17a"},
            {"fa fa-won", "\uf159"},
            {"fa fa-wordpress", "\uf19a"},
            {"fa fa-wpbeginner", "\uf297"},
            {"fa fa-wpexplorer", "\uf2de"},
            {"fa fa-wpforms", "\uf298"},
            {"fa fa-wrench", "\uf0ad"},
            {"fa fa-xing", "\uf168"},
            {"fa fa-xing-square", "\uf169"},
            {"fa fa-y-combinator", "\uf23b"},
            {"fa fa-y-combinator-square", "\uf1d4"},
            {"fa fa-yahoo", "\uf19e"},
            {"fa fa-yc", "\uf23b"},
            {"fa fa-yc-square", "\uf1d4"},
            {"fa fa-yelp", "\uf1e9"},
            {"fa fa-yen", "\uf157"},
            {"fa fa-yoast", "\uf2b1"},
            {"fa fa-youtube", "\uf167"},
            {"fa fa-youtube-play", "\uf16a"},
            {"fa fa-youtube-square", "\uf166"}
        };
            }
        }
    }
}