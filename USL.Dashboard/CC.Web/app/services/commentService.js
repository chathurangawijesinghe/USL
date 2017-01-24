angular.module('app').factory("commentService", ['$resource',
    function ($resource) {
        var host = 'http://localhost/SLD.Service/api';

        var commentsPath = "/Comment";

        return {
            getComments: function () {
                return $resource(host + commentsPath, {}, {
                    query: {
                        method: 'GET',
                        isArray: true
                    }
                });
            }
        };
    }
]);