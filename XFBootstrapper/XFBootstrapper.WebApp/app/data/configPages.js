//angular.module('app').value

var configPages = [
    {
        pageName: "Project Naming",
        routeName: "start",
        isActive: false,
        isValid: function (cValues) {
            return !(cValues.filter(function (configValue) {
                if (configValue.type == "string") {
                    return configValue.value === undefined || configValue.value.length < configValue.minLength;
                }
            }).length == 0);
        },
        //progress: 10,
        configValues: [
            {
                name: "Project Name",
                type: "string",
                value: undefined,
                template: '<config-value-input config-model="project.name" ng-change-handler="sanitizeProjectName()"></config-value-input>',
                minLength: 4,
            }
        ],
        isNextDisabled: function (project) {
            return project.name === undefined || project.name.length < 4;
        },
        isPreviousDisabled: function (cValues) {
            return true;
        },
    },
    {
        pageName: "Project Type",
        routeName: "type",
        isActive: false,
        isValid: function () {
            return false;
        },
        //progress: 10,
        configValues: [
            {
                name: "Project Type",
                type: "string",
                template: '<h1>Project Type Here</h1>',
                control: "select-grid",
                options: [
                    {
                        name: "Mobile Application"
                    },
                    {
                        name: "Web Application"
                    }
                ]
            }
        ],
        isNextDisabled: function () {
            return true;
        },
        isPreviousDisabled: function () {
            return false;
        }
    }
];