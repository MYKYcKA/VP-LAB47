function AddFeedback() {
    let feedbackAuthor = document.createElement("p"),
        line = document.createElement("hr"),
        feedbackDate = document.createElement("p"),
        feedbackText = document.createElement("p"),
        feedback = document.createElement("div");
    feedbackDate.innerHTML = formatDate(new Date());
    feedbackAuthor.innerHTML = document.getElementById("Name").value + " " + document.getElementById("Surname").value;
    line.classList.add("Article-Line");
    feedbackAuthor.classList.add("Name");
    feedbackDate.classList.add("Feedback-Date");
    feedbackText.classList.add("Feedback-text");
    feedbackText.innerHTML = document.getElementById("FeedTxt").value;
    feedback.appendChild(line);
    feedback.appendChild(feedbackAuthor);
    feedback.appendChild(feedbackDate);
    feedback.appendChild(feedbackText);
    document.getElementById("Feedbacks").appendChild(feedback);
}

const formatDate = (date) => {
    var d = new Date(date),
        month = "" + (d.getMonth() + 1),
        day = "" + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) {
        month = "0" + month;
    }
    if (day.length < 2) {
        day = "0" + day;
    }

    return [day, month, year].join(".");
};