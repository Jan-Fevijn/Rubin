<template>
    <v-app style="background: orange;">
        <v-container fill-height fluid justify-center align-center>
            <v-card width="400" max-width="400" min-height="300" style="border-radius: 20px;" align="center" light>
                <v-col class="text-left">
                    <v-btn icon @click="$router.push({name: 'Login'})">
                        <v-icon>
                            mdi-arrow-left
                        </v-icon>
                    </v-btn>
                </v-col>
                <v-img src="../assets/bread.png" height="125" width="125" class="my-3" />
                <v-card-text class="justify-center align-center ma-0">
                    <v-row dense>
                        <v-col>
                            <v-text-field label="Naam" v-model="klant.naam"></v-text-field>
                        </v-col>
                        <v-col>
                            <v-text-field label="Voornaam" v-model="klant.voornaam"></v-text-field>
                        </v-col>
                    </v-row>
                    <v-row dense justify="center" class="my-2">
                        <v-col cols="8">
                        <v-dialog ref="dialog" v-model="modal" :return-value.sync="date" persistent width="290px">
                            <template v-slot:activator="{ on }">
                                <v-text-field v-model="date" label="Geboortedatum" prepend-icon="mdi-calendar"
                                     v-on="on" dense></v-text-field>
                            </template>
                            <v-date-picker v-model="date" scrollable>
                                <v-spacer></v-spacer>
                                <v-btn text color="primary" @click="modal = false">Cancel</v-btn>
                                <v-btn text color="primary" @click="$refs.dialog.save(date)">OK</v-btn>
                            </v-date-picker>
                        </v-dialog>
                        </v-col>

                    </v-row>
                    <v-btn color="black white--text" @click="signUp" class="mb-2">
                        Sign up
                    </v-btn>
                    <v-dialog v-model="mconfirm" persistent max-width="290">
                        <v-card>
                            <v-card-title class="headline" v-if="!err">Registratie voltooid!</v-card-title>
                            <v-card-title class="headline" v-if="err">Registratie mislukt!</v-card-title>
                            <v-card-text v-if="!err">
                                Uw<b> Unieke code </b> is {{klant.klantcode}}.
                                 Deze code heeft u nodig om naar de webshop te gaan.
                            </v-card-text>
                            <v-card-text v-if="err">
                                Registratie is mislukt. <b>Niet alle velden waren ingevuld</b>
                            </v-card-text>
                            <v-card-actions>
                                <v-spacer>
                                    <v-btn color="green darken-1" text @click="confirm()">Ok</v-btn>
                                </v-spacer>
                            </v-card-actions>
                        </v-card>
                    </v-dialog>
                    <br>
                </v-card-text>
                
            </v-card>
        </v-container>
    </v-app>
</template>

<script>
import BakkerijApi from '../db.js'
    export default {
        data() {
            return {
                date: new Date().toISOString().substr(0, 10),
                modal: false,
                mconfirm: false,
                err: false,
                klant: {
                    klantcode: null,
                    naam: "",
                    voornaam: "",
                    dob: null,
                    saldo: 0.00
                }
            }
        },
        methods: {
            generateKlantCode(){
                let code = "";
                do {
                    let num = Math.floor(Math.random() * 10);
                    code += num.toString()
                } while(code.length < 10)
                return code
            },
            signUp: async function() {
                
                if(this.klant.name != "" && this.klant.voornaam != ""){
                this.klant.klantcode = this.generateKlantCode();
                this.klant.dob = this.date
                await BakkerijApi.insertUser(this.klant)
                this.err = false;
                } else {
                    this.err = true;
                }
                
                this.mconfirm = true;
            },
            confirm(){
                this.mconfirm = false;
                if(!this.err){
                    this.$router.push({name: 'Login'})
                }
                
            }
        },
    }
</script>