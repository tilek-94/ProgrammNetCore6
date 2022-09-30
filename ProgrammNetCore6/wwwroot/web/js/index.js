window.addEventListener("DOMContentLoaded", () => {
  // Jquery
  $(document).ready(function () {
    // Mobile menu
    $(function () {
      $(".mobile_menu").on("click", function () {
        $(".top_header_menu").toggle();
      });
    });

    // slider
    $(".sliderTop").slick({
      dots: true,
      infinite: true,
      speed: 500,
      cssEase: "linear",
      autoplay: true,
      autoplaySpeed: 2000,
    });
    //slider for popular products
    $(".popular-slider").slick({
      dots: true,
      infinite: true,
      speed: 300,
      slidesToShow: 4,
      slidesToScroll: 4,
      autoplay: true,
      responsive: [
        {
          breakpoint: 1024,
          settings: {
            slidesToShow: 3,
            slidesToScroll: 3,
            infinite: true,
            dots: true,
          },
        },
        {
          breakpoint: 768,
          settings: {
            slidesToShow: 2,
            slidesToScroll: 2,
          },
        },
        {
          breakpoint: 480,
          settings: {
            slidesToShow: 1,
            slidesToScroll: 1,
          },
        },
      ],
    });
    // menu
    $(".catalogTitle").on("click", function () {
      $(".catalogMenuLists").toggle();
    });

    $("#nav-icon4").click(function () {
      $(this).toggleClass("open");
    });

    // Change catalog view
    $(".viewList > div").click(function () {
      // Change active class
      $(".viewList > div ").not(this).removeClass("selected");
      $(this).addClass("selected");

      // Change view catalog
      if ($(this).is("#btn_view_1")) {
        $(".catalogProducts .tabloids").removeClass("view_list");
      } else {
        $(".catalogProducts .tabloids").addClass("view_list");
      }
    });

    // Change visiblity smartFilter for mobile
    $(window).click(function (e) {
      const filBtn = document.querySelector(".filterAllProduct");
      const filter = document.querySelector(".smartFilter");
      if (e.target === filBtn) {
        $(filter).toggleClass("show");
        $(filBtn).toggleClass("fillActive");
      }
    });

    // Change state heading
    $(".smartFilter .heading").click(function () {
      $(".smartFilter form").toggleClass("show");
    });

    // tabs
    const tabs = document.querySelectorAll(".category"),
      tabContent = document.querySelectorAll(".tContent"),
      headerParents = document.querySelector(".header_product_category");

    function hideTabContent() {
      tabContent.forEach((item) => {
        item.style.display = "none";
      });
      tabs.forEach((item) => {
        item.classList.remove("active_category");
      });
    }

    function showTabContent(i = 0) {
      $(tabContent[i]).css({ display: "block" });
      $(tabs[i]).addClass("active_category");
    }

    hideTabContent();
    showTabContent();

    $(headerParents).on("click", (e) => {
      if (e.target && e.target.classList.contains("category")) {
        tabs.forEach((item, i) => {
          if (item == e.target) {
            hideTabContent();
            showTabContent(i);
          }
        });
      }
    });

    // Expander parmasBox filter
    const paramsBoxs = document.querySelectorAll(".paramsBox");
    paramsBoxs.forEach((item) => {
      $(item.querySelector(".paramsBoxTitle")).click(function () {
        $(item).toggleClass("paramActive");
        $(item.querySelector(".propExpander")).toggleClass("expander");
      });
    });

    // Slice title product for mobile version
    const textProduct = document.querySelector(".product_text .middle");
    if (window.innerWidth <= 575 && textProduct.textContent.length > 10) {
      textProduct.textContent = textProduct.textContent.slice(0, 30);
    }
  });

  // function for openModal
  function openModalAuth() {
    document.querySelector(".modalAuth").style.display = "block";
  }
  // accordion
  let acc = document.querySelectorAll(".accordion");

  for (let i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function () {
      acc[i].classList.toggle("active");

      let panel = acc[i].nextElementSibling;
      if (panel.style.display === "block") {
        panel.style.display = "none";
      } else {
        panel.style.display = "block";
      }
    });
  }

  // modal window for auth
  const authBtn = document.querySelector(".authBtn");
  const modalAuth = document.querySelector(".modalAuth");
  const btnFormCancel = document.querySelector(".btnFormCancel");
  authBtn.addEventListener("click", () => {
    modalAuth.style.display = "block";
  });
  btnFormCancel.addEventListener("click", () => {
    modalAuth.style.display = "none";
  });

  // modal fast view
  const product = document.querySelector(".itempro");
  let getFastView = document.querySelectorAll(".getFastView"),
    modalForProdcut = document.querySelector(".modalForProdcut"),
    cancelModalProduct = document.querySelector(".fastViewHeader span");

  getFastView.forEach(item => {
    item.addEventListener("click", () => {
      modalForProdcut.style.display = "flex";
    });
  })

  cancelModalProduct.addEventListener("click", () => {
    modalForProdcut.style.display = "none";
  });

  window.addEventListener("click", (e) => {
    if (e.target === modalAuth) {
      modalAuth.style.display = "none";
    }
    if (e.target === modalForProdcut) {
      modalForProdcut.style.display = "none";
    }
  });

  const menuExistBtns = document.querySelectorAll('.menu_exists_btn');
  const menuExistContent = document.querySelectorAll('.catalogDrop');
  menuExistBtns.forEach((menuBtn, idx) => {
    menuBtn.addEventListener('click', () => {
      menuBtn.classList.toggle('active')
      menuExistContent[idx].classList.toggle('active');
    })
  })

});
