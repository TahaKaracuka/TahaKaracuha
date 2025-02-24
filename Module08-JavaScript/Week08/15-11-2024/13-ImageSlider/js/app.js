const slides = document.querySelectorAll(".slide");
const prevButton = document.querySelector(".prev");
const nextButton = document.querySelector(".next");

let currentIndex = 0;
let intervalTime = 5000;

function showSlide(index) {
    slides.forEach(function (slide, i) {
        slide.classList.remove("active");
        if (i == index) {
            slide.classList.add("active");
        }
    })
}

function nextSlide() {
    currentIndex = (currentIndex + 1) % slides.length;
    showSlide(currentIndex);
}

function prevSlide() {
    currentIndex = (currentIndex - 1 + slides.length) % slides.length;
    showSlide(currentIndex);
}

prevButton.addEventListener("click", function () {
    prevSlide();
    stopAutoSlide();
    startAutoSlide();
})

nextButton.addEventListener("click", function () {
    nextSlide();
    stopAutoSlide();
    startAutoSlide();
})

let interval;
// Otomatik geçişi başlatan fonksiyon
function startAutoSlide() {
    interval = setInterval(nextSlide, intervalTime);
}
// Otomatik geçişi durduran fonksiyon
function stopAutoSlide() {
    clearInterval(interval);
}



showSlide(currentIndex);
startAutoSlide();

