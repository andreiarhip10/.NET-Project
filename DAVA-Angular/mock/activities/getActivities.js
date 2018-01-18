var express = require('express');
var router = express.Router();

router.get('/getActivities', function(req, resp) {
    const user = req.query.username;

    if (user == 'admin') {
        resp.status(200);
        resp.json([
            {
                type: 'leisure',
                value: [{
                    name: 'first',
                    description: 'desc',
                    startingTime: '18.01.2018 08:00:00',
                    edingTime: '18.01.2018 08:00:00',
                    isFinished: false
                }, {
                    name: 'first',
                    description: 'desc',
                    startingTime: '18.01.2018',
                    edingTime: '18.01.2018',
                    isFinished: false
                }]
            }
        ])
    } else {
        if (user == 'dan') {
            resp.status(400);
            resp.json({
                message: "User not found."
            });
        }
    }
    
});

module.exports = router;