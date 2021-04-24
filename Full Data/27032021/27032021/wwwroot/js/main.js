/*-----------------------------------------------------------------------------------

  Template Name: Uniqlo-Minimalist eCommerce HTML5 Template.
  Template URI: #
  Description: Uniqlo is a unique website template designed in HTML with a simple & beautiful look. There is an excellent solution for creating clean, wonderful and trending material design corporate, corporate any other purposes websites.
  Author: HasTech
  Author URI: https://themeforest.net/user/hastech/portfolio
  Version: 1.1

-----------------------------------------------------------------------------------*/

/*-------------------------------
[  Table of contents  ]
---------------------------------
  01. jQuery MeanMenu
  02. wow js active
  03. Portfolio  Masonry (width)
  04. Sticky Header
  05. ScrollUp
  06. Tooltip
  07. ScrollReveal Js Init
  08. Fixed Footer bottom script ( Newsletter )
  09. Search Bar
  10. Toogle Menu
  11. Shopping Cart Area
  12. Filter Area
  13. User Menu
  14. Overlay Close
  15. Home Slider 
  16. Popular Product Wrap
  17. Testimonial Wrap
  18. Magnific Popup  
  19. Price Slider Active
  20.  Plus Minus Button
  21. jQuery scroll Nav

  

/*--------------------------------
[ End table content ]
-----------------------------------*/


(function ($) {
    'use strict';


    /*-------------------------------------------
      01. jQuery MeanMenu
    --------------------------------------------- */

    $('.mobile-menu nav').meanmenu({
        meanMenuContainer: '.mobile-menu-area',
        meanScreenWidth: "991",
        meanRevealPosition: "right",
    });

    /*-------------------------------------------
      02. wow js active
    --------------------------------------------- */

    new WOW().init();



    /*-------------------------------------------
      03. Product  Masonry (width)
    --------------------------------------------- */

    $('.htc__product__container').imagesLoaded(function () {

        // filter items on button click
        $('.product__menu').on('click', 'button', function () {
            var filterValue = $(this).attr('data-filter');
            $grid.isotope({ filter: filterValue });
        });
        // init Isotope
        var $grid = $('.product__list').isotope({
            itemSelector: '.single__pro',
            percentPosition: true,
            transitionDuration: '0.7s',
            layoutMode: 'fitRows',
            masonry: {
                // use outer width of grid-sizer for columnWidth
                columnWidth: 1,
            }
        });

    });

    $('.product__menu button').on('click', function (event) {
        $(this).siblings('.is-checked').removeClass('is-checked');
        $(this).addClass('is-checked');
        event.preventDefault();
    });



    /*-------------------------------------------
      04. Sticky Header
    --------------------------------------------- */


    var win = $(window);
    var sticky_id = $("#sticky-header-with-topbar");
    win.on('scroll', function () {
        var scroll = win.scrollTop();
        if (scroll < 245) {
            sticky_id.removeClass("scroll-header");
        } else {
            sticky_id.addClass("scroll-header");
        }
    });





    /*--------------------------
      05. ScrollUp
    ---------------------------- */
    $.scrollUp({
        scrollText: '<i class="zmdi zmdi-chevron-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });



    /*---------------------------
      06. Tooltip
    ------------------------------*/
    $('[data-toggle="tooltip"]').tooltip({
        animated: 'fade',
        placement: 'top',
        container: 'body'
    });



    /*-----------------------------------
      07. ScrollReveal Js Init
    -------------------------------------- */

    window.sr = ScrollReveal({ duration: 800, reset: false });
    sr.reveal('.foo');
    sr.reveal('.bar');



    /*-------------------------------------------------------
      08. Fixed Footer bottom script ( Newsletter )
    --------------------------------------------------------*/

    var $newsletter_height = $(".htc__foooter__area");
    $('.fixed__footer').css({ 'margin-bottom': $newsletter_height.height() + 'px' });




    /*------------------------------------    
      09. Search Bar
    --------------------------------------*/

    $('.search__open').on('click', function () {
        $('body').toggleClass('search__box__show__hide');
        return false;
    });

    $('.search__close__btn .search__close__btn_icon').on('click', function () {
        $('body').toggleClass('search__box__show__hide');
        return false;
    });




    /*------------------------------------    
      10. Toogle Menu
    --------------------------------------*/

    $('.toggle__menu').on('click', function () {
        $('.offsetmenu').addClass('offsetmenu__on');
        $('.body__overlay').addClass('is-visible');

    });

    $('.offsetmenu__close__btn').on('click', function () {
        $('.offsetmenu').removeClass('offsetmenu__on');
        $('.body__overlay').removeClass('is-visible');
    });



    /*------------------------------------    
      11. Shopping Cart Area
    --------------------------------------*/

    $('.cart__menu').on('click', function () {
        $('.shopping__cart').addClass('shopping__cart__on');
        $('.body__overlay').addClass('is-visible');

    });

    $('.offsetmenu__close__btn').on('click', function () {
        $('.shopping__cart').removeClass('shopping__cart__on');
        $('.body__overlay').removeClass('is-visible');
    });


    /*------------------------------------    
      12. Filter Area
    --------------------------------------*/

    $('.filter__menu').on('click', function () {
        $('.filter__wrap').addClass('filter__menu__on');
        $('.body__overlay').addClass('is-visible');

    });

    $('.filter__menu__close__btn').on('click', function () {
        $('.filter__wrap').removeClass('filter__menu__on');
        $('.body__overlay').removeClass('is-visible');
    });



    /*------------------------------------    
      13. User Menu
    --------------------------------------*/

    $('.user__menu').on('click', function () {
        $('.user__meta').addClass('user__meta__on');
        $('.body__overlay').addClass('is-visible');

    });

    $('.offsetmenu__close__btn').on('click', function () {
        $('.user__meta').removeClass('user__meta__on');
        $('.body__overlay').removeClass('is-visible');
    });



    /*------------------------------------    
      14. Overlay Close
    --------------------------------------*/
    $('.body__overlay').on('click', function () {
        $(this).removeClass('is-visible');
        $('.offsetmenu').removeClass('offsetmenu__on');
        $('.shopping__cart').removeClass('shopping__cart__on');
        $('.filter__wrap').removeClass('filter__menu__on');
        $('.user__meta').removeClass('user__meta__on');
    });



    /*-----------------------------------------------
      15. Home Slider
    -------------------------------------------------*/

    if ($('.slider__activation__wrap').length) {
        $('.slider__activation__wrap').owlCarousel({
            loop: true,
            margin: 0,
            nav: true,
            autoplay: false,
            navText: ['<i class="zmdi zmdi-chevron-left"></i>', '<i class="zmdi zmdi-chevron-right"></i>'],
            autoplayTimeout: 10000,
            items: 1,
            dots: false,
            lazyLoad: true,
            responsive: {
                0: {
                    items: 1
                },
                1920: {
                    items: 1
                }
            }
        });
    }

    if ($('.slider__activation__02').length) {
        $('.slider__activation__02').owlCarousel({
            loop: true,
            margin: 0,
            nav: false,
            autoplay: false,
            autoplayTimeout: 10000,
            items: 1,
            dots: false,
            lazyLoad: true,
            responsive: {
                0: {
                    items: 1
                },
                1920: {
                    items: 1
                }
            }
        });
    }




    /*-----------------------------------------------
      16. Popular Product Wrap
    -------------------------------------------------*/


    $('.popular__product__wrap').owlCarousel({
        loop: true,
        margin: 0,
        nav: true,
        autoplay: false,
        navText: ['<i class="zmdi zmdi-chevron-left"></i>', '<i class="zmdi zmdi-chevron-right"></i>'],
        autoplayTimeout: 10000,
        items: 3,
        dots: false,
        lazyLoad: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            800: {
                items: 2
            },
            1024: {
                items: 3
            },
            1200: {
                items: 3
            },
            1400: {
                items: 3
            },
            1920: {
                items: 3
            }
        }
    });



    /*-----------------------------------------------
      17. Testimonial Wrap
    -------------------------------------------------*/


    $('.testimonial__wrap').owlCarousel({
        loop: true,
        margin: 0,
        nav: false,
        autoplay: false,
        navText: false,
        autoplayTimeout: 10000,
        items: 1,
        dots: false,
        lazyLoad: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            800: {
                items: 1
            },
            1024: {
                items: 1
            },
            1200: {
                items: 1
            },
            1400: {
                items: 1
            },
            1920: {
                items: 1
            }
        }
    });




    /*--------------------------------
      18. Magnific Popup
    ----------------------------------*/

    $('.video-popup').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        zoom: {
            enabled: true,
        }
    });

    $('.image-popup').magnificPopup({
        type: 'image',
        mainClass: 'mfp-fade',
        removalDelay: 100,
        gallery: {
            enabled: true,
        }
    });





    /*-------------------------------
      19. Price Slider Active
    --------------------------------*/
    $("#slider-range").slider({
        range: true,
        min: 10,
        max: 500,
        values: [110, 400],
        slide: function (event, ui) {
            $("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);
        }
    });
    $("#amount").val("$" + $("#slider-range").slider("values", 0) +
        " - $" + $("#slider-range").slider("values", 1));




    /*-------------------------------
      20.  Plus Minus Button 
    --------------------------------*/


    $(".cart-plus-minus").append('<div class="dec qtybutton quantityMinus">-</i></div><div class="inc qtybutton quantityPlus">+</div>');

    $(".qtybutton").on("click", function () {
        var $button = $(this);
        var oldValue = $button.parent().find("input").val();
        if ($button.text() == "+") {
            var newVal = parseFloat(oldValue) + 1;
        } else {
            // Don't allow decrementing below zero
            if (oldValue > 1) {
                var newVal = parseFloat(oldValue) - 1;
            } else {
                newVal = 1;
            }
        }
        $button.parent().find("input").val(newVal);
    });


    /*--------------------------
      21. jQuery scroll Nav
    ---------------------------- */
    $('.onepage--menu').onePageNav({
        scrollOffset: 0
    });



    //Custom js
    $(".color").on("click", function (e) {
        e.preventDefault();
        let id = $(this).data("id");

        $.ajax({
            url: "/shop/getPriceByColor/" + id,
            type: "get",
            dataType: "json",
            success: function (response) {
                //console.log(response);

                if (response.isDiscount == true) {
                    let oldP = '<li class="old__prize">$' + response.price + '</li>'
                    let disP = '<li>$' + response.discountPrice + '</li>'

                    let ul = $(".pro__dtl__prize");
                    ul.empty();
                    ul.append(oldP);
                    ul.append(disP);
                } else {

                    let ul = $(".pro__dtl__prize");
                    ul.empty();
                    let P = '<li>$' + response.price + '</li>';
                    ul.append(P);
                }
            },
            error: function (response) {
                console.log(response);
            }
        });
    });


    $(".quantity").on("keyup", function (e) {
        e.preventDefault();

        if (parseInt($(this).val()) < 1) {
            $(this).val(1)
        }
    })

    $(".quantityPlus").on("click", function (e) {
        if (parseInt($(".quantity")[2].value) > parseInt($(".quantity")[2].dataset.max)) {
            $(".quantity")[2].value = parseInt($(".quantity")[2].dataset.max);
        }
    });

    $(".addToCartList").on("click", function (e) {
        e.preventDefault();
        $.LoadingOverlay("show");

        let id = parseInt($(this).data("id"));

        $.ajax({
            url: "/shop/addToCart/" + id,
            type: "get",
            dataType: "json",
            success: function (response) {
                console.log(response);
                $.LoadingOverlay("hide");
            },
            error: function (response) {
                console.log(response);
            }
        });

    });

    $(".removePrd").on("click", function (e) {
        e.preventDefault();
        $.LoadingOverlay("show");
        let This = this;

        let price = parseFloat($(this).data("price").replace(",", "."))
        let qunatity = parseFloat($(this).data("quantity").toString().replace(",", "."))
        let totalPriceRemovedPrd = price * qunatity;
        let total = parseFloat($("#subTotal").text().slice(1, $("#subTotal").text().length));
        let newTotal = total - totalPriceRemovedPrd;
        let finalTotal = 0;

        let id = parseInt($(this).data("id"));

        $.ajax({
            url: "/shop/removeFromCart/" + id,
            type: "get",
            dataType: "json",
            success: function (response) {
                console.log(this);

                //Update totals
                $("#subTotal").text("$" + newTotal.toFixed(2));

                let shipping_method = $("#shipping_method");
                shipping_method.empty();
                let li = $("<li></li>");

                if (newTotal < 100) {
                    let label = $("<label></label>");
                    let span = $('<span class="amount">$7.00</span>');
                    label.append(span);
                    li.append(label);
                    shipping_method.append(li);
                    finalTotal = newTotal + 7;
                } else {
                    let label = $("<label></label>");
                    let span = $('<span class="amount">Free</span>');
                    label.append(span);
                    li.append(label);
                    shipping_method.append(li);
                    finalTotal = newTotal;
                }

                $(".finalTotal").text("$" + finalTotal.toFixed(2));
                //End of update codes

                This.closest('tr').remove();

                $.LoadingOverlay("hide");

                //window.location.href = "/shop/cart";
            },
            error: function (response) {
                console.log(response);
            }
        });
    });

    $(".quantityCart").on("change", function (e) {
        e.preventDefault();
        //$.LoadingOverlay("show");

        let price = parseFloat($(this).data("price").replace(",", "."));
        let quantity = parseFloat($(this).val().replace(",", "."));
        let maxQunatity = parseFloat($(this).data("max").replace(",", "."));
        let id = parseFloat($(this).data("id"));
        let This = this;
        if (quantity < 1) {
            $(this).val(1);
            quantity = 1;
        }
        if (quantity > maxQunatity) {
            $(this).val(maxQunatity);
            quantity = maxQunatity;
        }


        $.ajax({
            url: "/shop/updateCart/",
            type: "get",
            data: {
                id,
                quantity
            },
            dataType: "json",
            success: function (response) {
                console.log(response);
                if (response == 404) {
                    alert("Not found!");
                }
                if (response == 200) {
                    let subTotal = 0;

                    This.closest('tr').children[4].innerText = "$" + (price * quantity);
                    for (var i = 0; i < $(".product-subtotal").length; i++) {
                        subTotal += parseFloat($(".product-subtotal")[i].innerText.slice(1, 6).replace(",", "."));
                    }

                    document.getElementById("subTotal").innerText = "$" + subTotal.toFixed(2);

                    let finalTotal = subTotal;
                    if (subTotal < 100) {
                        finalTotal = subTotal + 7;
                        document.getElementsByClassName("amountShopping")[0].innerText = "$7.00"
                        document.getElementsByClassName("finalTotal")[0].innerText = "$" + finalTotal.toFixed(2);
                    } else {
                        document.getElementsByClassName("amountShopping")[0].innerText = "FREE"
                        document.getElementsByClassName("finalTotal")[0].innerText = "$" + finalTotal.toFixed(2);
                    }
                }
            },
            error: function (response) {
                console.log(response);
            }
        });

    });

    $(".quantityCart").on("keyup", function (e) {
        e.preventDefault();
        let quantity = parseFloat($(this).val());
        let maxQunatity = parseFloat($(this).data("max"));

        if (quantity < 1) {
            $(this).val(1);
        }
        if (quantity > maxQunatity) {
            $(this).val(maxQunatity);
        }
    });


    $("#remind-me").on("change", function (e) {
        e.preventDefault();

        if ($(this).is(':checked')) {
            $("#CreateAccout").css("display", "block");
        } else {
            $("#CreateAccout").css("display", "none");
        }

    });

    $(".rating").on("click", function () {
        $(".rating").css("border", "unset");

        $(this).css("border","1px solid #f3c258");
        $('input[name="Rating"]').val($(this).data("rating"));
    })

})(jQuery);




