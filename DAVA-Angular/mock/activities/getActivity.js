var express = require('express');
var router = express.Router();

router.get('/getActivity', function(req, resp) {
    const user = req.query.username;
    const activityId = req.query.id;

    if (user == 'admin' && activityId == '23') {
        resp.status(200);
        resp.json([
            {
                type: 'housework',
                values: [{
                    name: 'dished',
                    description: 'do the dishes',
                    startingTime: '18.01.2018 12:00:00',
                    endingTime: '18.01.2018 13:00:00',
                    isFinished: false
                }]
            }
        ])
    }

    if (activityId == '100') {
        resp.status(400);
        resp.json({
            message: "Activity not found."
        })
    }

    if (user == 'dan') {
        resp.status(400);
        resp.json({
            message: "User not found."
        })
    }

    if (user == 'user' && activityId == '4') {
        resp.status(200);
        resp.json([
            {
                type: 'leisure',
                values: [{
                    name: 'movie',
                    description: 'watch blade runner',
                    startingTime: '19.01.2018 20:00:00',
                    endingTime: '19.01.2018 22:00:00',
                    isFinished: false
                }]
            }
        ])
    }

    if (user == 'user' && activityId == '12') {
        resp.status(200);
        resp.json([
            {
                type: 'work',
                values: [{
                    name: 'documentation',
                    description: 'read about angular',
                    startingTime: '20.01.2018 10:00:00',
                    endingTime: '20.01.2018 12:00:00',
                    isFinished: false
                }]
            }
        ])
    }
});

module.exports = router;