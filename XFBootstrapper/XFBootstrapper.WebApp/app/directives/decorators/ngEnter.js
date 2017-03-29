"use strict";
// Use to add an "on enter pressed" event, evaluates the expression in the attribute's value
// ex. <input ng-enter="isEditing = false" />
angular.module('app').directive('ngEnter', function () {
    return function (scope, element, attrs) {
        element.bind("keydown keypress", function (event) {
            if (event.which === 13) {
                scope.$apply(function () {
                    scope.$eval(attrs.ngEnter, { 'event': event });
                });
            }
            //event.preventDefault();
        });
    };
});