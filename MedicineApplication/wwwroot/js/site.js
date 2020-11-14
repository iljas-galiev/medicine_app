function AddMessage() {
    var message = $messagecontent.val().trim();
    if (message.length == 0) {
        return false;
    }
    connection.invoke("SendMessage", message);
    $messagecontent.val('');
}

$(document).ready(function () {
    var connection = new WebSocketManager.Connection("ws://localhost:5000/msg");
    connection.enableLogging = true;

    connection.connectionMethods.onConnected = () => {

    }

    connection.connectionMethods.onDisconnected = () => {

    }

    connection.clientMethods["pingMessage"] = (socketId, message) => {
        var messageText = socketId + ' said: ' + message;
        $('#messages').append('<li>' + messageText + '</li>');
        $('#messages').scrollTop($('#messages').prop('scrollHeight'));
    }

    connection.start();

    var $messagecontent = $('#message');
    $messagecontent.keyup(function (e) {
        if (e.keyCode == 13) {
            AddMessage();
        }
    });

    $('.chat-form').on('submit', function (e) {
        e.prefentDefault();
        AddMessage();
        return false;
    });

    $('#messages').scrollTop($('#messages').prop('scrollHeight'));
});
