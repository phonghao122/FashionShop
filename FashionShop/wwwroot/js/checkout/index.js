
$('#frm-customer-info').validate({
    rules: {
        FirstName:
        {
            required: true,
        },
        LastName:
        {
            required: true,
        },
        Email:
        {
            required: true,
        },
        Country:
        {
            required: true,
        },
        StreetAddress:
        {
            required: true,
        },
        City:
        {
            required: true,
        },
        PhoneNumber:
        {
            required: true,
        },
        PaymentMethod:
        {
            required: true,
        },

    },
    messages: {
        FirstName:
        {
            required: "You must input First Name",
        },
        LastName:
        {
            required: "You must input Last Name",
        },
        Email:
        {
            required: "You must input Email",
        },
        Country:
        {
            required: "You must input Country",
        },
        StreetAddress:
        {
            required: "You must input Street Address",
        },
        City:
        {
            required: "You must input City",
        },
        PhoneNumber:
        {
            required: "You must input Phone Number",
        },

        PaymentMethod:
        {
            required: "You must choose the Payment Method",
        },

    }
});


function placeOrder(e) {
    /*e.preventDefault()*/
    if ($('#frm-customer-info').valid()) {
        var paymentMethod = Number($('#txt-payment-method').val())
        if (paymentMethod <= 0 || paymentMethod > 3) {
            $.notify("Please select one payment method", "warn")
            return
        }
        var checkTerm = $('#terms').prop("checked");
        if (!checkTerm) {
            $.notify("please accept the term", "warn")
            return
        }
        
        var form = $('#frm-customer-info');
        form.submit();
    }
};

function addCheckoutMethodValue() {
    var value = $(this).val();
    $('#txt-payment-method').val(value);
}
function init() {
  
    var message = $('#check-out-message').text();
    var status = Number( $('#check-out-status').text()) ;
    if (message != '') {
        var messageType = status == 200 ? "success": "error"
        $.notify(message, messageType);
    }
}
init();
$('body').on('click', '#btn-place-order', (e) => placeOrder(e));
$('body').on('input', '.input-radio input', addCheckoutMethodValue);