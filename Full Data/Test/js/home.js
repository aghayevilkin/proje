fetch("./layouts/header.html")
    .then(response => {
        return response.text()
    })
    .then(data => {
        document.querySelector("header").innerHTML = data;
    });

fetch("./layouts/home/main.html")
    .then(response => {
        return response.text()
    })
    .then(data => {
        document.querySelector("main").innerHTML = data;
    });

fetch("./layouts/footer.html")
    .then(response => {
        return response.text()
    })
    .then(data => {
        document.querySelector("footer").innerHTML = data;
    });

    // Scroll

    $(document).ready(function () {
      $(window).scroll(function () {
        var scroll = $(window).scrollTop();
        var doc = $(document).height();
        var win = $(window).height();
        var value = (scroll / (doc - win)) * 80;
        $("ul .line").css("height", value + "%");
      });
    });
