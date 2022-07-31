// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const { selectors } = require("sizzle");

// Write your JavaScript code.

function showModal(CourseId) {
		 let selector = "course-student-modal-" + CourseId;
		 $(selectors).show();
}
function hideModal(CourseId) {
		 let selector = "course-student-modal-" + CourseId;
		 $(selectors).hide();
}
