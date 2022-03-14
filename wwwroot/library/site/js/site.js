
//Mobil burger button
$(document).ready(function () {
    $('#nav-icon4').click(function () {
        $(".navbar-gen").toggleClass("active");

        $(this).toggleClass('open');
        //$("body").toggleClass("disable-scroll");
        $('html, body').toggleClass("disable-scroll-prog");
        $(".sub-control").removeClass("sub-menu-open");
        $(".main-menu-item .main-link i").remove();
        $(".menu-gen").attr("style", "background-color:#000000");
        $(".sub-control").attr("style", "background-color:#151515");
    });

    $('.mobil-close').click(function () {
        closeNav();


    });
});



function closeNav() {
    $('#navbarSupportedContent').addClass('collapse');
    $('#navbarSupportedContent').removeClass('show');

    $('#nav-icon4').removeClass('open');
    $('html, body').css({
        overflow: 'auto',
        height: 'auto'
    });
}
function openNav() {

    $("#mySidenav").toggleClass('acik');
    $("#menu-text").toggleClass('menu-text-acik');
    $("#main").toggleClass('main');

}





//$(window).resize(function () {

//    window.location.reload();
//});















//Slider Default
var swiperAnimation = new SwiperAnimation();
var swiper = new Swiper('.default-slider', {
    //autoHeight: true,
    spaceBetween: 0,
    centeredSlides: true,
    effect: 'fade',
    loop: true,


    autoplay: {
        delay: 5000,
        disableOnInteraction: false,
    },
    pagination: {
        el: '.swiper-pagination',
        clickable: true,
        dynamicBullets: true,
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
    //mousewheel: {
    //    eventsTarged: ".swiper-slide",
    //    sensitivity: 5
    //},
    on: {
        init: function () {
            swiperAnimation.init(this).animate();
            $('.swiper-progress-bar').removeClass('animate');
            $('.swiper-progress-bar').removeClass('active');
            $('.swiper-progress-bar').eq(0).addClass('animate');
            $('.swiper-progress-bar').eq(0).addClass('active');
        },
        slideChange: function () {
            swiperAnimation.init(this).animate();
        },

        slideChangeTransitionStart: function () {
            $('.swiper-progress-bar').removeClass('animate');
            $('.swiper-progress-bar').removeClass('active');
            $('.swiper-progress-bar').eq(0).addClass('active');
        },
        slideChangeTransitionEnd: function () {
            $('.swiper-progress-bar').eq(0).addClass('animate');
        }
    }
});

var swiper = new Swiper('.urun-slider', {
    //speed: 800,
    slidesPerView: 6,
    spaceBetween: 8,
    loop: true,
    //centeredSlides: true,
    autoplay: {
        delay: 3500,
        disableOnInteraction: false,

    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
    breakpoints: {
        1498: {
            slidesPerView: 4,
            spaceBetween: 8
        },
        1199: {
            slidesPerView: 3,
            spaceBetween: 8
        },
        991: {
            slidesPerView: 3,
            spaceBetween: 8
        },
        767: {
            slidesPerView: 2,
            spaceBetween: 8
        },
        575: {
            slidesPerView: 2,
            spaceBetween: 8
        },
        //415: {
        //    slidesPerView: 1,
        //    spaceBetween: 0
        //}
    }
});

var swiper = new Swiper(".ebrochure-slider", {
    slidesPerView: 3,
    spaceBetween: 30,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    breakpoints: {
        1498: {
            slidesPerView: 3,
            spaceBetween: 8
        },
        1199: {
            slidesPerView: 3,
            spaceBetween: 8
        },
        991: {
            slidesPerView: 3,
            spaceBetween: 8
        },
        767: {
            slidesPerView: 2,
            spaceBetween: 8
        },
        575: {
            slidesPerView: 2,
            spaceBetween: 8
        },
        415: {
            slidesPerView: 1,
            spaceBetween: 0
        }
    }
});