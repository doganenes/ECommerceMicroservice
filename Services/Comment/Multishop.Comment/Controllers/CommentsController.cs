using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Comment.Context;
using Multishop.Comment.Entities;

namespace Multishop.Comment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CommentsController : ControllerBase
    {
        private readonly CommentContext _commentContext;

        public CommentsController(CommentContext context)
        {
            _commentContext = context;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            _commentContext.UserComments.ToList();
            return Ok(_commentContext.UserComments);
        }

        [HttpPost]
        public IActionResult CreateComment(UserComment userComment)
        {
            if (userComment == null)
            {
                return BadRequest("Invalid comment data.");
            }
            _commentContext.UserComments.Add(userComment);
            _commentContext.SaveChanges();
            return Ok("Comment created successfully.");
        }

        [HttpPut]
        public IActionResult UpdateComment(UserComment userComment)
        {
            _commentContext.UserComments.Update(userComment);
            _commentContext.SaveChanges();
            return Ok("Comment updated successfully!");
        }

        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var comment = _commentContext.UserComments.Find(id);
            if (comment == null)
            {
                return NotFound("Comment not found.");
            }
            _commentContext.UserComments.Remove(comment);
            _commentContext.SaveChanges();
            return Ok("Comment deleted successfully.");
        }

        [HttpGet("{id}")]
        public IActionResult GetCommentById(int id)
        {
            var comment = _commentContext.UserComments.Find(id);
            if (comment == null)
            {
                return NotFound("Comment not found.");
            }
            return Ok(comment);
        }
    }
}
