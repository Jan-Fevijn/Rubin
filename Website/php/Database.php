<?php
  class Database
  {
    private $conn;
    function __construct($host, $username,$password, $dbname, $port)
    {
      $this->conn = mysqli_connect($host, $username, $password, $dbname, $port);
    }
    public function Select($sqlString){
      $result = $this->conn->query($sqlString);
      return $result;
    }
    public function Insert($sqlString){
      if($this->conn->query($sqlString) === TRUE){
        return TRUE;
      } else {
        return FALSE;
      }
    }

    public function Update($sqlString){
      if($this->conn->query($sqlString) === TRUE){
        return TRUE;
      } else {
        return FALSE;
      }
    }
  }
 ?>
