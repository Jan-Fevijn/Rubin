<template>
<v-app style="background: orange;">
    <v-container fill-height fluid justify-center align-center>
        <v-card width="300" max-width="350" min-height="300" style="border-radius: 20px;" align="center" light>
                <v-img src="../assets/bread.png" height="125" width="125" class="my-3"/>
                <v-card-text class="justify-center align-center ma-0">
                    <v-text-field dense label="Code" style="width: 150px;" v-model="code"></v-text-field>
                    
                    <v-btn color="black white--text" @click="login" class="mb-2">
                    Sign in
                    </v-btn>
                    <br>
                    <router-link to="/signup" style="text-decoration: none;">Create an account.</router-link>
                </v-card-text>
                
        </v-card>
    </v-container>
</v-app>
</template>
<script>
export default {
    data() {
        return {
            code: ""
        }
    },
    methods: {
        login: async function() {
            await this.$store.dispatch('checkLogin', this.code);
            /*if (isLoggedIn){
                this.$router.push({name: 'App'})
            }*/
            //console.log('Logged in ...');
            //console.log(this.$store.state.test)
        }
    },
}
</script>
