$(document).ready(function () {
    var user = $('#user').val()

    function AddMessage($messagecontent) {
        var message = $messagecontent.val().trim();
        if (message.length == 0) {
            return false;
        }
        connection.invoke("SendMessage", message, user);
        $messagecontent.val('');
    }

    var connection = new WebSocketManager.Connection("wss://kfu-medicine-app.herokuapp.com/msg");
    connection.enableLogging = true;

    connection.connectionMethods.onConnected = () => {

    }

    connection.connectionMethods.onDisconnected = () => {

    }

    connection.clientMethods["pingMessage"] = (user, message, date) => {
        var messageText = '<div class="message-entity">\n' +
            '                    <div class="message-header">\n' +
            '                        <span class="message-user">\n' +
            user +
            '                        </span>\n' +
            '                        <span class="message-datetime">\n' +
            date +
            '                        </span>\n' +
            '                    </div>\n' +
            '                    <div class="message-text">\n' +
            message +
            '                    </div>\n' +
            '                </div>';
        $('.message-list').prepend(messageText);
        $(window).scrollTop(0);
        //
    }

    connection.start();

    var $messagecontent = $('#message');
    $messagecontent.keyup(function (e) {
        if (e.keyCode == 13) {
            AddMessage($messagecontent);
        }
    });

    $('.chat-form').on('submit', function (e) {
        e.preventDefault();
        AddMessage($messagecontent);
        return false;
    });

    $('#messages').scrollTop($('#messages').prop('scrollHeight'));
});

