const mysql = require('mysql');

const pool = mysql.createPool({
    connectionLimit: 10,
    password: 'usbw',
    user: 'root',
    database: 'bakkerij',
    host: 'localhost',
    port: '3306'
});


let db = {};
//  Select brood
db.brood = () => {
    return new Promise((resolve, reject) =>{
        pool.query(`SELECT * FROM brood`, (err, results) => {
            if (err){
                return reject(err);
            }
            return resolve(results)
        });
    });
};
// Select Transactie
db.transacties = (klantcode) => {
    return new Promise((resolve, reject) =>{
        pool.query(`SELECT * FROM transactie where klantcode = ?`,[klantcode], (err, results) => {
            if (err){
                return reject(err);
            }
            return resolve(results)
        });
    });
};
// Get Klant
db.klant = (klantCode) => {
    return new Promise((resolve, reject) =>{
        pool.query(`SELECT * FROM klant WHERE klantcode = ?`, [klantCode] , (err, results) => {
            if (err){
                return reject(err);
            }
            if (results){
                return resolve(results[0])
            } else{
                return reject("Geen Gebruiker gevonden")
            }
            
        });
    });
}
// Create Klant
db.createUser = (klant) => {
    return new Promise((resolve, reject) =>{
        try {
            pool.query(`INSERT INTO klant(klantcode, naam, voornaam, saldo, dob) VALUES(?,?,?,?,?)`,
            [klant.klantcode, klant.naam, klant.voornaam, klant.saldo, klant.dob], (err, results) =>{
            if (err){
                return reject(err)
            }
            return resolve(results)
        })
        } catch (error) {
            console.log(error)
        }
        
    });
}
// Update Klant saldo
db.updateSaldo = (klant) => {
    return new Promise((resolve, reject) => {
        pool.query(`Update klant set saldo = ? WHERE klantcode = ?`, [klant.saldo, klant.klantcode], (err, results) =>{
            if (err){
                return reject(err)
            }
            return resolve(results)
        })
    });
}

// Insert Transactie
db.createTransaction = (transactie) => {
    return new Promise((resolve, reject) =>{
        pool.query(`INSERT INTO transactie(idBrood, klantCode, datum) VALUES(?,?,?)`,
        [transactie.idBrood,transactie.klantcode, getDate()], (err, results) =>{
            if (err){
                return reject(err)
            }
            return resolve(results)
        })
    })
}

function getDate(){
    let today = new Date();
    let dd = today.getDate();
    let mm = today.getMonth() +1;
    let yyyy = today.getFullYear();
   
    if(dd < 10){
      dd = "0" + dd
    }
    if(mm < 10){
      mm = "0" + mm
    }
    let date = yyyy + "-" + mm + "-" + dd
    return date
}
module.exports = db