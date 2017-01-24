(function () {
    'use strict';

    var controllerId = 'admins';

    angular.module('app').controller(controllerId, ['$routeParams', 'common', 'config', 'userFactory', admins]);

    function admins($routeParams, common, config, userFactory) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);
        var keyCodes = config.keyCodes;
        var vm = this;

        vm.users = [];
        vm.title = 'Admins';
        vm.refresh = refresh;

        activate();

        function activate() {
            common.activateController([getAdmins()], controllerId)
                .then(function () {
                    log('Activated Admin View');
                });
        }

        function getAdmins() {
            vm.users = userFactory.init(1);
        }

        function refresh() {
            getAdmins(true);
        }
    }
})();
