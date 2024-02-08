var ViewModel = function () {
    var self = this;
    self.users = ko.observableArray();
    self.error = ko.observable();
    self.detail = ko.observable();

    var usersUri = '/api/users/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllUsers() {
        ajaxHelper(usersUri, 'GET').done(function (data) {
            self.users(data);
        });
    }

    // Fetch the initial data.
    getAllUsers();

    self.getUserDetail = function (item) {
        ajaxHelper(usersUri + item.Id, 'GET').done(function (data) {
            self.detail(data);
        });
    }
};

ko.applyBindings(new ViewModel());