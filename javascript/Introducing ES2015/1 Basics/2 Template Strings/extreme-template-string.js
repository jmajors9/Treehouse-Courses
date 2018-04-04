'use strict';

const student = { name: 'James', followerCount: 34 };

// the backtick at beginning and end is absolutely necessary for this to work.
let tableHtml = `
  <table class="table">
    <thead>
      <tr>
        <td>Name</td>
        <td>Followers</td>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>${student.name}</td>
        <td>${student.followerCount}</td>
      </tr>
    </tbody>
  </table>`;

// the ${} is to allow for instertion from 
console.log(tableHtml);

// also checkout tagged template literals
