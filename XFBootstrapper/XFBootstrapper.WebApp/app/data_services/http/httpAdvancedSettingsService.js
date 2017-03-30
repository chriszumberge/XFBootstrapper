"use strict";
angular.module('app').factory('httpAdvancedSettingsService', ['httpServiceBase', function (httpServiceBase) {
    var advancedSettingsService = {};

    advancedSettingsService.getAdvancedSettings = function () {
        return httpServiceBase.httpGet("AdvancedSettings");
    };

    return advancedSettingsService;
}]);