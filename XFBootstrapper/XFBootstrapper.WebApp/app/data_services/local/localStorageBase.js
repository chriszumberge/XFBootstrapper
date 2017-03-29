angular.module('app').factory("localStorageBase", ["localStorageService",
    function (localStorageService) {
        var _getLocalStorageValue = function (key, val) {
            if (_localStorageValueIsSet(key)) {
                return localStorageService.get(key);
            }
            else {
                return undefined;
            }
        };

        var _setLocalStorageValue = function (key, val) {
            return localStorageService.set(key, val);
        };

        var _localStorageValueIsSet = function (key) {
            return localStorageService.keys().indexOf(key) >= 0;
        };

        var _getInitialLocalStorageValues = function (key, defaultValue) {
            var storedValue = _getLocalStorageValue(key);

            if (storedValue == undefined) {
                _setLocalStorageValue(key, defaultValue);
                storedValue = defaultValue;
            }

            return storedValue;
        };

        return {
            getLocalStorageValue: _getLocalStorageValue,
            setLocalStorageValue: _setLocalStorageValue,
            localStorageValueIsSet: _localStorageValueIsSet,
            getInitialLocalStorageValues: _getInitialLocalStorageValues
        };
    }
]);