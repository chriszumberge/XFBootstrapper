//angular.module('app').value

var configPages = [
    // config pages are defined by the system
    {
        pageName: "Services and Features",
        routeName: "features",
        configCategories: [
            {
                categoryName: "Authentication",
                configOptions: [
                    {
                        optionName: "Facebook",
                        isEnabled: true,
                        configValues: [
                            {
                                name: "Auth Key",
                                value: undefined,
                                helpText: "",
                                helpLink: "",
                                template: '<config-value-input config-model="project.features.authentication.facebook.authkey" label="Facebook Auth Key"></config-value-input>'
                            }
                        ]
                    },
                    {
                        optionName: "Google",
                        isEnabled: true,
                        configValues: [
                            {
                                name: "Auth Key",
                                value: undefined,
                                helpText: "",
                                helpLink: "",
                                template: '<config-value-input config-model="project.features.authentication.google.authkey" label="Google Auth Key"></config-value-input>'
                            }
                        ]
                    }
                ]
            },
            {
                categoryName: "Push Notifications",
                configOptions: [
                    {
                        optionName: '',
                        isEnabled: true,
                        configValues: [
                            {

                            }
                        ]
                    }
                ]
            }
        ]
    },
    {
        pageName: "Advanced Settings",
        routeName: "advanced",
        configOptions: [
            {
                optionName: "Business Logic",
                isEnabled: true,
                configValues: [
                    {
                        template: '',
                        options: [
                            { id: 1, name: "In Application with Azure Mobile Service as Backend", isEnabled: "if type is mobile application" },
                            { id: 2, name: "Customized .Net WebApi Backend", isEnabled: false },
                            { id: 3, name: "Customized node.js Backend", isEnabled: false }
                        ]
                    }
                ]
            }
        ]
    }
];