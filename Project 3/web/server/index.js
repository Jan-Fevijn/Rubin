// Import Express
const express = require('express');
const cors = require('cors');
const apiRouter = require('./routes');
// Initialize Express

const app = express();



// Middleware
app.use(express.json())
app.use(cors());
app.use(express.urlencoded({extended: false}));
app.use('/api/bakkerij', apiRouter)
// Handle Production

if(process.env.NODE_ENV === 'production'){
    // Static folder
    app.use(express.static(__dirname + '/public/'))
    
    // Handle SPA
    app.get(/.*/, (req, res) => res.sendFile(__dirname + '/public/index.html'));
}

const port = process.env.PORT || 5000;

app.listen(port, err => err ? console.log("Error occured :", err) : console.log(`Listening on port ${port}`));