(function () {
    'use strict';

    var app = angular.module('app');

    // Collect the routes
    app.constant('routes', getRoutes());
    
    // Configure the routes and route resolvers
    app.config(['$routeProvider', 'routes', routeConfigurator]);
    function routeConfigurator($routeProvider, routes) {

        routes.forEach(function (r) {
            setRoute(r.url, r.config);
        });
        $routeProvider.otherwise({ redirectTo: '/' });

        function setRoute(url, definition) {
            $routeProvider.when(url, definition);
            return $routeProvider;
        }
    }

    // Define the routes 
    function getRoutes() {
        return [
            {
                url: '/',
                config: {
                    templateUrl: 'app/dashboard/dashboard.html',
                    title: 'dashboard',
                    settings: {
                        nav: 1,
                        content: '<i class="fa fa-dashboard"></i> Dashboard'
                    }
                }
            }, {
                url: '/admin',
                config: {
                    title: 'admin',
                    templateUrl: 'app/admin/admin.html',
                    settings: {
                        nav: 2,
                        content: '<i class="fa fa-calendar"></i> Admins'
                    }
                }
            }, {
                url: '/checker',
                config: {
                    title: 'checker',
                    templateUrl: 'app/checker/checker.html',
                    settings: {
                        nav: 2,
                        content: '<i class="fa fa-user"></i> Checkers'
                    }
                }
            }, {
                url: '/definer',
                config: {
                    title: 'definer',
                    templateUrl: 'app/definer/definer.html',
                    settings: {
                        nav: 2,
                        content: '<i class="fa fa-user"></i> Definers'
                    }
                }
            }, {
                url: '/user',
                config: {
                    title: 'users',
                    templateUrl: 'app/user/user.html',
                    settings: {
                        nav: 2,
                        content: '<i class="fa fa-group"></i> Users'
                    }
                }
            }//,
            //{
            //    url: '/sessions/search/:search',
            //    config: {
            //        title: 'sessions-search',
            //        templateUrl: 'app/session/sessions.html',
            //        settings: {}
            //    }
            //}
        ];
    }
})();