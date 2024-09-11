tinymce.init({
    selector: '#tinyEditor',
    plugins: [
        // Core editing features
        'link',
    ],
    toolbar: 'undo redo | fontfamily fontsize | bold italic underline | link | align | indent outdent |',
    tinycomments_mode: 'embedded',
    tinycomments_author: 'Author name',
    mergetags_list: [
        { value: 'First.Name', title: 'First Name' },
        { value: 'Email', title: 'Email' },
    ],
    ai_request: (request, respondWith) => respondWith.string(() => Promise.reject('See docs to implement AI Assistant')),
});
