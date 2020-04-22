const axios = require('axios');
const URL = "http://localhost:5000/api/bakkerij/";

class BakkerijApi
{
    // Registreren
    static async insertUser(data){
        try {
            const response = await axios.post(`${URL}klant/create`, data);
            return response
        } catch (e) {
            console.log(e);
        }
    }
    // Login
    static async login(data){
        try {
            const response = await axios.get(`${URL}klant/${data}`)
            return response
        } catch (e) {
            console.log(e)
            
        }
    }
}


module.exports = BakkerijApi