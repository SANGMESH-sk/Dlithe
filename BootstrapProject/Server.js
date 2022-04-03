console.log("this is same");

function Book(name, author, type) {
  this.name = name;
  this.author = author;
  this.type = type;
}

function Display() {}
//Add method to display prototype in ui
Display.prototype.add = function (book) {
  console.log("adding to UI");

  tableBody = document.getElementById("tableBody");
  let uiString = `<tr>
            
    <td>${book.name}</td>
    <td>${book.author}</td>
    <td>${book.type}</td>
  </tr>`;
  tableBody.innerHTML += uiString;
};
//implementing the validaing
Display.prototype.validate = function (book) {
  if (book.name.length < 2 || book.author.length < 2) {
    return false;
  } else {
    return true;
  }
};
Display.prototype.show = function (type, displaymessege) {
  let message = document.getElementById("messege");
  message.innerHTML = `<div class="alert alert-${type} alert-dismissible fade show" role="alert">
  <strong>message!</strong>${displaymessege}.
  <button type="button" class="close" data-dismiss="alert" aria-label="Close">
    <span aria-hidden="true">&times;</span>
  </button>
</div>`;
  setTimeout(function () {
    message.innerHTML = "";
  }, 2000);
};

// reset form when we add values
Display.prototype.clear = function () {
  let libraryForm = document.getElementById("libraryForm");
  libraryForm.reset();
};

// add submit event listner to library
var libraryForm = document.getElementById("libraryform");
libraryForm.addEventListener("submit", libraryFormSubmit);

// taking users value
function libraryFormSubmit(e) {
  console.log("working");

  let name = document.getElementById("bookname").value;
  let author = document.getElementById("author").value;
  let type;

  let fiction = document.getElementById("Fiction");
  let programming = document.getElementById("programming");
  let cooking = document.getElementById("cooking");

  if (fiction.checked) {
    type = fiction.value;
  } else if (programming.checked) {
    type = programming.value;
  } else if (cooking.checked) {
    type = cooking.value;
  }

  let book = new Book(name, author, type);

  let display = new Display();

  // display.clear()
  e.preventDefault();
  if (display.validate(book)) {
    display.add(book);
    display.show("success", "your book has been added");
  } else {
    display.show("danger", "sorry you cannot add your book");
  }
}
