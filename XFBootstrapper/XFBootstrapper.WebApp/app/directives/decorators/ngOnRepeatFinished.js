"use strict";
var app = angular.module('app');

// to use, add the on-layout attribute to an element WITH an ng-repeat, set to the value of an expression to run
// ex. <div ng-repeat="item in selectedItems" ng-on-repeat-finished="attachInkRipple()"> ... </div>
app.directive('ngOnRepeatFinished', function ($timeout) {
    return {
        restrict: 'A',
        link: function (scope, element, attr) {
            if (scope.$last === true) {
                $timeout(function () {
                    scope.$emit(attr.onLayout, { "element": element });
                });
            }
        }
    }
});