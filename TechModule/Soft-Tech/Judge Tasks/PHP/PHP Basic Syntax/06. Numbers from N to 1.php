<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if(isset($_GET['num'])){
    $n = $_GET['num'];
    for ($a = intval($n); $a >=1; $a--){
        if($a == 1){
            echo $a;
        }
        else{
            echo "$a ";
        }
    }
}
?>
</body>
</html>