if (window.console) {
  console.log("Welcome to your Play application's JavaScript!");
  $("#doctorInfoDeleteMsg").hide();
}
$( "#btnSignin" ).click(function() {
  $( "#intro" ).hide("fast");
  $( "#signIn" ).show("slow");
});
$( "#login" ).click(function() {
  alert("Wrong user name or password");
  $( "#signIn" ).hide("fast");
  $( "#menuItems" ).show("slow");
});
$('#doctorTab a').click(function (e) {
  e.preventDefault()
  $(this).tab('show')
});
$('#patientTab a').click(function (e) {
  e.preventDefault()
  $(this).tab('show')
});
$('#employeeTab a').click(function (e) {
  e.preventDefault()
  $(this).tab('show')
});
$("#doctorInfoDelete").click(function () {
	$("#doctorInfoDeleteMsg").show();
	$("#doctorInfoDeleteMsg").text("Doctor's information is not found");
});