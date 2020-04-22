import Vue from 'vue';
import Vuex from 'vuex';
import Api from '../db';
Vue.use(Vuex);

export const store = new Vuex.Store({
     state:{
        currentKlant: null,
        LoggedIn : false,
     },
     getters: {

     },
     mutations: {
        klantInit: (state,klant) =>{
            state.currentKlant = klant;
            state.LoggedIn = true;
        }
     },
     actions: {
        checkLogin: async function(context, klantCode){
            let klant = await Api.login(klantCode);
            if (klant.data.klantCode != ""){
            context.commit('klantInit', klant.data)
            return true
            }else{
                console.log("Geen Klant Gevonden")
            }
        }
     }
})