! function(e) {
    "use strict";
    var t = e(window);
    t.on("load", function() {
        var a = e(document),
            o = e("html, body"),
            s = e(".preloader"),
            g = e(".client-logo-carousel"),
            p = e(".blog-post-carousel"),
            v = e(".select-container-select"),
            h = e(".card-preview"),
            f = e(".user-text-editor"),
            y = e(".category-carousel"),
            b = e(".featured-course-carousel"),
            w = e(".fullscreen-slider"),
            k = e(".generic-portfolio-list"),
            C = e('[data-fancybox="gallery"]'),
            S = e(".datepicker"),
            x = e(".emoji-picker"),
            T = e(".counter"),
            q = e(".tags-input"),
            H = e(".qtyBtn"),
            L = e("#phone"),
            I = e(".cv-input"),
            j = e(".lazy"),
            z = e(".skillbar");
        s.delay("500").fadeOut(2e3), a.on("click", ".down-button", function() {
            e(this).toggleClass("active"), e(".header-top").slideToggle(200)
        }), t.on("resize", function() {
            t.width() > 991 ? e(".header-top").show() : e(".header-top").hide()
        }), e(".search-menu-toggle").on("click", function() {
            e(".mobile-search-form, .body-overlay").addClass("active"), e("body").css({
                overflow: "hidden"
            })
        }), e(".search-bar-close, .body-overlay").on("click", function() {
            e(".mobile-search-form, .body-overlay").removeClass("active"), e("body").css({
                overflow: "inherit"
            })
        }), e(".cat-menu-toggle").on("click", function() {
            e(".category-off-canvas-menu, .body-overlay").addClass("active"), e("body").css({
                overflow: "hidden"
            })
        }), e(".cat-menu-close, .body-overlay").on("click", function() {
            e(".category-off-canvas-menu, .body-overlay").removeClass("active"), e("body").css({
                overflow: "inherit"
            })
        }), e(".main-menu-toggle").on("click", function() {
            e(".main-off-canvas-menu, .body-overlay").addClass("active"), e("body").css({
                overflow: "hidden"
            })
        }), e(".main-menu-close, .body-overlay").on("click", function() {
            e(".main-off-canvas-menu, .body-overlay").removeClass("active"), e("body").css({
                overflow: "inherit"
            })
        }), e(".user-menu-toggle").on("click", function() {
            e(".user-off-canvas-menu, .body-overlay").addClass("active"), e("body").css({
                overflow: "hidden"
            })
        }), e(".user-menu-close, .body-overlay").on("click", function() {
            e(".user-off-canvas-menu, .body-overlay").removeClass("active"), e("body").css({
                overflow: "inherit"
            })
        }), e(".dashboard-menu-toggler").on("click", function() {
            e(".off--canvas-menu, .body-overlay").addClass("active"), e("body").css({
                overflow: "hidden"
            })
        }), e(".dashboard-menu-close, .body-overlay").on("click", function() {
            e(".off--canvas-menu, .body-overlay").removeClass("active"), e("body").css({
                overflow: "inherit"
            })
        }), e(".off-canvas-menu-list .sub-menu").parent("li").children("a").append(function() {
            return '<button class="sub-nav-toggler" type="button"><i class="la la-angle-down"></i></button>'
        }), e(".sub-nav-toggler").on("click", function() {
            var t = e(this);
            return t.toggleClass("active"), t.parent().parent().siblings().children("a").find(".sub-nav-toggler").removeClass("active"), t.parent().parent().children(".sub-menu").slideToggle(), t.parent().parent().siblings().children(".sub-menu").slideUp(), !1
        });
        var M = e("#scroll-top");
        t.on("scroll", function() {
            e(this).scrollTop() > 200 ? (e(".header-menu-content").addClass("fixed-top"), e("body").css("margin-top", e(".header-menu-content").outerHeight() + "px")) : (e(".header-menu-content").removeClass("fixed-top"), e("body").css("margin-top", "0")), e(this).scrollTop() >= 300 ? M.show() : M.hide();
            0 !== e(".skills .skill").length && spy_scroll(".skills .skill")
        }), a.on("click", "#scroll-top", function() {
            e(o).animate({
                scrollTop: 0
            }, 1e3)
        }), e(".page-scroll").on("click", function(t) {
            t.preventDefault();
            var a = e(this.hash);
            e(o).animate({
                scrollTop: a.offset().top - 20
            }, 600)
        }),  e(g).length && e(g).owlCarousel({
            loop: !0,
            rtl: !0,
            items: 3,
            nav: !1,
            dots: !1,
            smartSpeed: 500,
            autoplay: !0,
            responsive: {
                0: {
                    items: 2
                },
                481: {
                    items: 2
                },
                768: {
                    items: 2
                },
                992: {
                    items: 3
                }
            }
        }),  e(b).length && e(b).owlCarousel({
            loop: !0,
            rtl: !0,
            items: 3,
            nav: !0,
            dots: !1,
            smartSpeed: 500,
            autoplay: !1,
            margin: 20,
            autoHeight: !0,
            navText: ["<i class='la la-arrow-left'></i>", "<i class='la la-arrow-right'></i>"]
        }), e(w).length && e(w).owlCarousel({
            loop: !0,
            rtl: !0,
            items: 3,
            nav: !0,
            dots: !1,
            smartSpeed: 500,
            autoplay: !1,
            margin: 20,
            autoHeight: !0,
            navText: ["<i class='la la-arrow-left'></i>", "<i class='la la-arrow-right'></i>"],
            responsive: {
                320: {
                    items: 1
                },
                768: {
                    items: 2
                },
                992: {
                    items: 3
                }
            }
        }), e('[data-toggle="tooltip"]').tooltip(), a.on("click", ".portfolio-filter li", function() {
            var t = e(this).attr("data-filter");
            e(k).isotope({
                filter: t
            }), e(".portfolio-filter li").removeClass("active"), e(this).addClass("active")
        }), e(k).length && e(k).isotope({
            itemSelector: ".generic-portfolio-item",
            percentPosition: !0,
            masonry: {
                columnWidth: ".generic-portfolio-item",
                horizontalOrder: !0
            }
        }), e(C).length && e(C).fancybox(), e(h).length && e(h).tooltipster({
            contentCloning: !0,
            interactive: !0,
            side: "right",
            delay: 100,
            animation: "swing"
        }), e(f).length && e(f).jqte({
            formats: [
                ["p", "Paragraph"],
                ["h1", "Heading 1"],
                ["h2", "Heading 2"],
                ["h3", "Heading 3"],
                ["h4", "Heading 4"],
                ["h5", "Heading 5"],
                ["h6", "Heading 6"],
                ["pre", "Preformatted"]
            ]
        }), e(S).length && e(S).dateDropper({
            format: "d-m-Y",
            theme: "vanilla",
            large: !0,
            largeDefault: !0
        }), e(x).length && e(x).emojioneArea({
            pickerPosition: "top"
        }), e(T).length && e(T).counterUp({
            delay: 10,
            time: 1e3
        }), e(q).length && e(q).tagsinput({
            tagClass: "badge badge-info",
            maxTags: 3
        }), e(".curriculum-sidebar-list > .course-item-link").on("click", function() {
            var t = e(this);
            t.addClass("active"), t.siblings().removeClass("active"), t.is(".active-resource") ? e(".lecture-viewer-text-wrap").addClass("active") : t.not(".active-resource") && e(".lecture-viewer-text-wrap").removeClass("active")
        }), a.on("click", ".sidebar-close", function() {
            e(".course-dashboard-sidebar-column, .course-dashboard-column, .sidebar-open").addClass("active")
        }), a.on("click", ".sidebar-open", function() {
            e(".course-dashboard-sidebar-column, .course-dashboard-column, .sidebar-open").removeClass("active")
        }), a.on("click", ".ask-new-question-btn", function() {
            e(".new-question-wrap, .question-overview-result-wrap").addClass("active")
        }), a.on("click", ".question-meta-content, .question-replay-btn", function() {
            e(".replay-question-wrap, .question-overview-result-wrap").addClass("active")
        }), a.on("click", ".back-to-question-btn", function() {
            e(".new-question-wrap, .question-overview-result-wrap, .replay-question-wrap").removeClass("active")
        }), a.on("click", ".swapping-btn", function() {
            var t = e(this);
            t.text() == t.data("text-swap") ? t.text(t.data("text-original")) : t.text(t.data("text-swap"))
        }), a.on("click", ".collection-link", function() {
            e(this).children(".collection-icon").toggleClass("active")
        }), e(v).length && e(v).selectpicker({
            liveSearch: !0,
            liveSearchPlaceholder: "Search",
            liveSearchStyle: "contains",
            size: 5
        }), a.on("click", ".share-toggle", function() {
            var t = e(this);
            t.parent().find(".social-icons").toggleClass("social-active"), t.toggleClass("share-toggle-active")
        }), e(".dropdown-btn").on("click", function(t) {
            t.preventDefault(), e(this).next(".dropdown-menu-wrap").fadeToggle(100), t.stopPropagation()
        }), a.on("click", function(t) {
            var a = e(".dropdown");
            a === t.target || a.has(t.target).length || e(".dropdown-menu-wrap").fadeOut(100)
        }), e(H).length && e(H).on("click", function() {
            var t = e(this),
                a = t.parent().find(".qtyInput").val();
            if (t.hasClass("qtyInc")) var o = parseFloat(a) + 1;
            else o = a > 0 ? parseFloat(a) - 1 : 0;
            t.parent().find(".qtyInput").val(o)
        });
        for (var P = document.querySelectorAll(".payment-tab-toggle > input"), D = 0; D < P.length; D++) P[D].addEventListener("change", O);

        function O(e) {
            for (var t = document.querySelectorAll(".payment-tab"), a = 0; a < t.length; a++) t[a].classList.remove("is-active");
            e.target.parentNode.parentNode.classList.add("is-active")
        }
        const A = document.querySelector(".copy-input"),
            E = document.querySelector(".copy-btn"),
            F = document.querySelector(".success-message");
        e(E).on("click", function() {
            A.select(), document.execCommand("copy"), A.blur(), F.classList.add("active"), setTimeout(function() {
                F.classList.remove("active")
            }, 2e3)
        }), e(I).length && e(I).MultiFile({
            accept: "pdf, doc, docx, rtf, html, odf, zip"
        }), e(j).length && e(j).Lazy();
        var N, U = document.querySelector("#send-message-btn"),
            B = e(".contact-form"),
            Q = e(".contact-success-message");

        function W(e) {
            U.innerHTML = "Send Message", Q.fadeIn().removeClass("alert-danger").addClass("alert-success"), Q.text(e), setTimeout(function() {
                Q.fadeOut()
            }, 3e3), B.find('input:not([type="submit"]), textarea').val("")
        }

        function Y(e) {
            U.innerHTML = "Send Message", Q.fadeIn().removeClass("alert-success").addClass("alert-danger"), Q.text(e.responseText), setTimeout(function() {
                Q.fadeOut()
            }, 3e3)
        }
        B.submit(function(t) {
            t.preventDefault(), N = e(this).serialize(), U.innerHTML = "Sending...", setTimeout(function() {
                e.ajax({
                    type: "POST",
                    url: B.attr("action"),
                    data: N
                }).done(W).fail(Y)
            }, 2e3)
        });
        const _ = document.querySelectorAll(".theme-picker-btn"),
            G = window.matchMedia("(prefers-color-scheme: dark)"),
            J = localStorage.getItem("theme");
        "dark" === J ? document.body.classList.toggle("dark-theme") : "light" === J && document.body.classList.toggle("light-theme"), _.forEach(function(e) {
            e && e.addEventListener("click", function() {
                if (G.matches) {
                    document.body.classList.toggle("light-theme");
                    var e = document.body.classList.contains("light-theme") ? "light" : "dark"
                } else {
                    document.body.classList.toggle("dark-theme");
                    e = document.body.classList.contains("dark-theme") ? "dark" : "light"
                }
                localStorage.setItem("theme", e)
            })
        }), e(z).length && e(z).each(function() {
            e(this).find(".skillbar-bar").animate({
                width: e(this).attr("data-percent")
            }, 6e3)
        })
    })
}(jQuery);

$(document).ready(function(){
	//top carousel function
	var owl = $('.top-carousel');
	owl.on('changed.owl.carousel', function(event) {
    	$('.top-preview-button').children('a').removeClass('animated').addClass('animated');
	})
	$('.top-carousel').owlCarousel({
		items: 1,
		dots: true,
		autoplay: false,
		loop: true,
	});
	$('.top-carousel .owl-dots').addClass('container');
	//open top carousel card positioning functions
	$('.top-preview-button').children('a').on('click', function(e){
		e.preventDefault();
		var selectedPoint = $(this).parent('li');
		if( selectedPoint.hasClass('is-open') ) {
			selectedPoint.removeClass('is-open').addClass('visited');
		} else {
			selectedPoint.addClass('is-open').siblings('.top-preview-button.is-open').removeClass('is-open').addClass('visited');
		}
	});
	//close top carousel card positioning functions
	$('.cd-close-info').on('click', function(event){
		event.preventDefault();
		$(this).parents('.top-preview-button').eq(0).removeClass('is-open').addClass('visited');
	});
	$(".main-menu ul li a").on("click", function(t) {
            var c = $(this.hash);
            if(c.length !==0 ){
                $("html,body").animate({
                    scrollTop : c.offset().top
                }, 900);
            }
        })
});