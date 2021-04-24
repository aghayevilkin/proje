fetch("./layouts/header.html")
    .then(response => {
        return response.text()
    })
    .then(data => {
        document.querySelector("header").innerHTML = data;
    });

fetch("./layouts/about/main.html")
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