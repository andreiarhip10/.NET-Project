var express = require('express');
var router = express.Router();

router.get('/getActivities', function(req, resp) {
    const user = req.query.username;

    if (user == 'admin') {
        resp.status(200);
        resp.json([
            {
                type: 'Leisure',
                value: [{
                    id: 23,
                    name: 'first',
                    description: 'desc',
                    startingTime: '18.01.2018 08:00:00',
                    edingTime: '18.01.2018 08:00:00',
                    isFinished: false
                }, {
                    id: 35,
                    name: 'second',
                    description: 'desc',
                    startingTime: '18.01.2018',
                    edingTime: '18.01.2018',
                    isFinished: false
                }]
            },
            {
                type: 'Work',
                value: [{
                    id: 1,
                    name: 'third',
                    description: 'desc',
                    startingTime: '18.01.2018 08:00:00',
                    edingTime: '18.01.2018 08:00:00',
                    isFinished: false
                }, {
                    id: 5,
                    name: 'fourth',
                    description: 'desc',
                    startingTime: '18.01.2018',
                    edingTime: '18.01.2018',
                    isFinished: false
                }]
            },
            {
                type: 'Housework',
                value: [{
                    id: 122,
                    name: 'sec',
                    description: 'desc',
                    startingTime: '18.01.2018 08:00:00',
                    edingTime: '18.01.2018 08:00:00',
                    isFinished: false
                }, {
                    id: 51,
                    name: '4th',
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