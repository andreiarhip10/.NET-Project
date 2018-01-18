var express = require('express');
var router = express.Router();

router.get('/getUser', function (req, resp) {

    const user1 = {
        username: 'user1',
        password: 'user1pas',
        email: 'user1@yahoo.com'
    }

    const user2 = {
        username: 'user2',
        password: 'user2pas',
        email: 'user2@yahoo.com'
    }

    const user = req.query.username;

    if (user == 'user1') {
        resp.status(200)
        resp.json(user1)
    }

    if (user == 'user2') {
        resp.status(200)
        resp.json(user2)
    }

    if (user == 'dan') {
        resp.status(400)
        resp.json({
            message: 'User not found.'
        })
    }
    });

module.exports = router;