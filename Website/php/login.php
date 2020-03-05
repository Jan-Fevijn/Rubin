<?php
  require_once 'vendor/autoload.php';

$g_client = new Google_Client();

$g_client->setClientId("8960574912-r7651bubfpp67kie5vaamskrk5es38rn.apps.googleusercontent.com");
$g_client->setClientSecret("8Cy0FP4G7Y4hZDnEP0ginN5r");
$g_client->setRedirectUri("http://localhost/sign_in/google.php");
$g_client->setScopes("email");
//Step 2 : Create the url
$auth_url = $g_client->createAuthUrl();

//Step 3 : Get the authorization  code
$code = isset($_GET['code']) ? $_GET['code'] : NULL;
//Step 4: Get access token
if(isset($code)) {
    try {

        $token = $g_client->fetchAccessTokenWithAuthCode($code);
        $g_client->setAccessToken($token);
    }catch (Exception $e){
        echo $e->getMessage();
    }




    try {
        $pay_load = $g_client->verifyIdToken();


    }catch (Exception $e) {
        echo $e->getMessage();
    }

} else{
    $pay_load = null;
}

if(isset($pay_load)){

}








?>
