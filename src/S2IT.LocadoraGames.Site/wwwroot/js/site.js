// Write your JavaScript code.
function Validations() {

    $('#DataEmprestimo').datepicker({
        format: "dd/mm/yyyy",
        startDate: "today",
        language: "pt-BR",
        orientation: "bottom right",
        autoclose: true
    });


    toastr.options = {
        "closeButton": false,
        "debug": true,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": true,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
}
