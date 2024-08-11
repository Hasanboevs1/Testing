import React from 'react';
import { render } from '@testing-library/react';
import '@testing-library/jest-dom/extend-expect';
import Greeting from './Greeting';

test('renders greeting message', () => {
  // Arrange & Act
  const { getByText } = render(<Greeting name="John" />);

  // Assert
  expect(getByText('Hello, John!')).toBeInTheDocument();
});
