const { expect } = require('chai');
const add = require('./math');

describe('add function', () => {
  it('yigindisi qaytishi kerak', () => {
    const result = add(2, 3);
    expect(result).to.equal(5);
  });

  it('manfiy sonlar yigindisi qaytishi kerak', () => {
    const result = add(-2, -3);
    expect(result).to.equal(-5);
  });
});