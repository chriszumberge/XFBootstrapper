"use strict";
//Ignores mousewheel event.  Helpful for html5 input of type number
angular.module('app').directive('ngIgnoreMouseWheel', function ($rootScope) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            element.bind('mousewheel', function (event) {
                element.blur();
            });
        }
    }
});