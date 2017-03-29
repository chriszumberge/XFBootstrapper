"use strict;"
angular.module('app').directive('configPageContentBody', ['$compile',
    function ($compile) {
        return {
            templateUrl: '/app/infrastructure/configPageContentBodyTemplate.html',
            link: function (scope, element, attrs) {
                var newElement = angular.element(scope.configValue.template);
                element.append(newElement);
                $compile(newElement)(scope);
            }
        }
    }
]);