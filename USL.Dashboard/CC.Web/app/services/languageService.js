angular.module('app').factory("languageService", ['$resource',
    function ($resource) {
        var host = 'http://localhost/SLD.Service/api';

        var languagePath = "/Language";

        return {
            getLanguages: function () {
                return $resource(host + languagePath, {}, {
                    query: {
                        method: 'GET',
                        isArray: true
                    }
                });
            },
            getLanguage: function () {
                return $resource(host + languagePath, {}, {
                    query: {
                        method: 'GET',
                        isArray: true,
                        params: {
                            userTypeId: '@userTypeId'
                        }
                    }
                });
            }
        };
    }
]);