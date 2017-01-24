(function () {
    'use strict';
    var controllerId = 'dashboard';
    angular.module('app').controller(controllerId, ['common', 'countService', 'commentService', 'languageService', dashboard]);

    function dashboard(common, countService, commentService, languageService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.attendeeCount = 0;
        vm.speakerCount = 0;
        vm.sessionCount = 0;
        vm.languages = {
            predicate: '',
            reverse: false,
            title: 'Languages'
        };
        vm.map = {
            title: 'Location'
        };
        vm.comments = {
            interval: 5000,
            title: 'Top Comments'
        };
        vm.news = {
            title: 'USL System',
            description: 'Enable all sign language systems used to configure all languages'
        };
        vm.title = 'Dashboard';

        activate();

        function activate() {
            var promises = [getCounts(), getLanguages(), getComments()];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Dashboard View'); });
        }

        function getCounts() {
            var countData = countService.getUsersByType();
            countData.query({
            }).$promise.then(function (response) {
                vm.counts = response;
            }, function (error) {
                alert(error);
            });
        }

        function getLanguages() {
            var languageData = languageService.getLanguages();
            languageData.query({
            }).$promise.then(function (response) {
                vm.languages.list = response;
            }, function (error) {
                alert(error);
            });
        }

        function getComments() {
            var commentData = commentService.getComments();
            commentData.query({
            }).$promise.then(function (response) {
                vm.comments.list = response;
            }, function (error) {
                alert(error);
            });
        }
    }
})();