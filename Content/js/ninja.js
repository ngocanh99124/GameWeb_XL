addEventListener('load', function () {
    var source_mute = document.getElementById("source_mute");
    source_mute.addEventListener('click', function () {
        if (this.className === "source") {
        this.className = "mute";
      }
        else {
        this.className = "source";
      }
    })
  });
