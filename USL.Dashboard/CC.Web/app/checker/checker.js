(function () {
    'use strict';

    var controllerId = 'checkers';

    angular.module('app').controller(controllerId, ['$routeParams', 'common', 'config', 'userFactory', checkers]);

    function checkers($routeParams, common, config, userFactory) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);
        var keyCodes = config.keyCodes;
        var vm = this;

        vm.checkers = [];
        vm.title = 'Checkers';
        vm.refresh = refresh;

        activate();

        function activate() {
            common.activateController([getCheckers()], controllerId)
                .then(function () {
                    log('Activated Checker View');
                });
        }

        function getCheckers() {
            vm.checkers = userFactory.init(2);
        }

        function refresh() {
            getCheckers(true);
        }
    }
})();
