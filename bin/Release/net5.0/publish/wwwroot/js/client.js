$(function(){
    // preload audio
    var toast = new Audio('toast.wav');

    $('.code').on('click', function(e) {
        e.preventDefault();
        //add discount title
        let discountTitle = $(this).attr("data-product");
        $('#title').html(discountTitle);

        //add discount code
        var code = $(this).attr("data-code")
        $('#code').html(code);

        //first pause the audio (in case it is still playing)
        toast.pause();
        //reset the audio
        toast.currentTime = 0;
        toast.play();
       
        $('#toast').toast({ autohide: false }).toast('show');
    });


    
});

$(document).on('keydown', (e) => {
    if (e.key == 'Escape') {
        $('#toast').toast('hide');
    }
});
