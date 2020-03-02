function initializeSliders() {
    //initialize swiper when document ready
    var swiper = new Swiper('.swiper-container', {
        // Optional parameters
        grabCursor: true,
        loop: false,
        parallax: true,
        speed: 600,

        autoplay: {
            delay: 3000,
        },

        keyboard: {
            enabled: true,
        },

        // If we need pagination
        pagination: {
            el: '.swiper-pagination',
            clickable: true
        },

        // Navigation arrows
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
            hideOnClick: true
        },

    });

    $(window).mousemove(function (e) {
        var change;
        var xpos = e.clientX; var ypos = e.clientY; var left = change * 20;
        var xpos = xpos * 2; ypos = ypos * 2;
        $('.parallax-bg').css('top', ((0 + (ypos / 50)) + "px"));
        $('.parallax-bg').css('left', ((0 + (xpos / 80)) + "px"));
        console.log(xpos, ypos);
    });
}