if (window.console) {
  console.log("Welcome to your Play application's JavaScript!");
}
$( "#btnSignin" ).click(function() {
  $( "#intro" ).hide("fast");
  $( "#signIn" ).show("slow");
});
