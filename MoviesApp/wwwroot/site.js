function toLeft(id) {
    const slider = document.getElementById(id);

    let space = getSpaceInSlider(slider);
    let extra = 0;
    if ((slider.scrollLeft + slider.offsetWidth) >= slider.scrollWidth) {
        extra = 50;
    }

    scrollHorizontally(slider, -space, extra);    
}

function toRight(id) {
    const slider = document.getElementById(id);

    let space = getSpaceInSlider(slider);
    let extra = 0;
    if (slider.scrollLeft === 0) {
        extra = 50;
    }
    
    scrollHorizontally(slider, space, -extra);
}

function getSpaceInSlider(slider) {
    let sliderWidth = slider.offsetWidth;
    let numberOfMovies = parseInt(sliderWidth / 290);
    return numberOfMovies * 290;
}

function scrollHorizontally(slider, space, extra) {
    slider.scrollBy({
        left: space + extra,
        top: 0,
        behavior: "smooth"
    });
}

function createOnScrollEvent(id) {
    const slider = document.getElementById(id);
    const leftBtn = document.getElementById("left-" + id);
    const rightBtn = document.getElementById("right-" + id);

    if (slider.scrollLeft != 0) {
        leftBtn.style.display = "initial";
    }
    if ((slider.scrollLeft + slider.offsetWidth) >= slider.scrollWidth) {
        rightBtn.style.display = "none";
    }

    slider.onscroll = e => {
        if (slider.scrollLeft === 0) {
            leftBtn.style.display = "none";
        } else {
            leftBtn.style.display = "initial";
        }

        if ((slider.scrollLeft + slider.offsetWidth) >= slider.scrollWidth) {
            rightBtn.style.display = "none";
        } else {
            rightBtn.style.display = "initial";
        }
    }
}