const express = require('express');
const db = require('../db')
const router = express.Router();
// * brood
router.get('/', async (req, res) =>{
    try{
        let results = await db.brood();
        res.json(results);
    } catch(e){
        console.log(e)
        res.sendStatus(500);
    }
});
// Transactions
router.get('/transaction/:code', async(req,res) =>{
    try {
        let results = await db.transacties(req.params.code);
        res.json(results)
    } catch (e) {
        console.log(e)
        res.sendStatus(500);
    }
})
// User
router.get('/klant/:code', async (req, res) =>{
    try{
        let results = await db.klant(req.params.code);
        res.json(results);
    } catch(e){
        console.log(e)
        res.sendStatus(500);
    }
});

// Create Klant
router.post('/klant/create', async(req, res) =>{
    try {
        await db.createUser(req.body);
        res.sendStatus(201)
    } catch (e) {
        console.log(e)
        res.sendStatus(500)
    }
});

// Create Transaction
router.post('/transaction/create', async(req, res)=>{
    try {
        await db.createTransaction(req.body);
        res.sendStatus(201);
    } catch (e) {
        console.log(e)
        res.sendStatus(500)
    }
});

// Update Klant Saldo
// Create Transaction
router.post('/klant/updateSaldo', async(req, res)=>{
    try {
        await db.updateSaldo(req.body);
        res.sendStatus(200);
    } catch (e) {
        console.log(e)
        res.sendStatus(500)
    }
});



module.exports = router;