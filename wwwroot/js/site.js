
$(document).ready(function () {
    var slider = $('.slider').bxSlider({
        onSlideBefore: updateSliderCaptions
    });
    updateSliderCaptions();

    $('.slider-back').click(function () {
        slider.goToPrevSlide();
        updateSliderCaptions();
    });

    $('.slider-next').click(function () {
        slider.goToNextSlide();
        updateSliderCaptions();
    });

    function updateSliderCaptions() {

        var current = slider.getCurrentSlide();
        var category = $('.slider .one-slide:not(.bx-clone)')[current].getAttribute("data-category");
        var title = $('.slider .one-slide:not(.bx-clone)')[current].getAttribute("data-title");

        $('.captions h3').text(category);
        $('.captions h2').text(title);
    }
});

