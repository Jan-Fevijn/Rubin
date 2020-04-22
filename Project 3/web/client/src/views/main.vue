<template>
    <div><p>Logged In Bruv</p></div>
</template>
<script>
export default {
    mounted() {
        console.log(this.$store.state.LoggedIn)
    },
}
</script>