document.addEventListener('DOMContentLoaded', function () {
  // === Hover for logo-container descriptions ===
  const logoContainers = document.querySelectorAll('.logo-container');

  logoContainers.forEach(container => {
    const description = container.querySelector('.hover-description');

    container.addEventListener('mouseenter', () => {
      if (description) description.style.display = 'block';
    });

    container.addEventListener('mouseleave', () => {
      if (description) description.style.display = 'none';
    });
  });

  // === Hover for image placeholder -> show generated image ===
  const uploadContainers = document.querySelectorAll('.upload-container');

  uploadContainers.forEach(container => {
    const image = container.querySelector('.generated-image');
    const placeholder = container.querySelector('.image-placeholder');

    container.addEventListener('mouseenter', () => {
      if (image && placeholder) {
        image.style.opacity = '1';
        placeholder.style.opacity = '0';
      }
    });

    container.addEventListener('mouseleave', () => {
      if (image && placeholder) {
        image.style.opacity = '0';
        placeholder.style.opacity = '1';
      }
    });
  });
});

