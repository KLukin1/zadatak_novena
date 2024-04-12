
$(document).ready(function () {
    var slider = $('.slider').bxSlider();
    $('.slider-back').click(function () {
        slider.goToPrevSlide();
    });

    $('.slider-next').click(function () {
        slider.goToNextSlide();
    });


})
