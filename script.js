
// window. Alert = function(message) {
//     alert(message);
// }
import swal from 'sweetalert';
window.methods = {

    alert : function(message){
        swal({
            title: message
            });
    },

    CreateCookie: function(name, value, days) {
     var expires;
     if (days) {
        var date = new Date();
         date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
          expires = "; expires=" + date.toGMTString();
     }
      else {
         expires = "";
     }
      document.cookie = name + "=" + value + expires + "; path=/";
   },
}
